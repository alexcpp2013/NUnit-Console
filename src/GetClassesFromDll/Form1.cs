#region C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Security.Permissions;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
#endregion

#region XMLCode
using System.Xml;
#endregion

//TODO
//Пути с пробелами не раюотают
//Проверить кирилицу в названиях

namespace GetClassesFromDll
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();
        private string className = "";
        private const string resultName = "TestResult.xml";
        private string resultNewName = "";
        private const string config = "config.xml";

        public Form1()
        {
            InitializeComponent();
            //ClearAll();
        }

        private void ClearAll()
        {
            ClearInputData();
            ClearGUIData();
            tbdll.Text = "";
            tbConfig.Text = config;
            tbNUnit.Text = "";
            tbXSL.Text = "";
        }

        private async void btSubmit_Click(object sender, EventArgs e)
        {
            btSubmit.Enabled = false;
            ProgressBar.Visible = true;

            if (cblbTree.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Не выбраны тестовые методы для запуска.\n",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tmp = await Task<int>.Run(() =>
                {
                    int result = 0;
                    Thread.Sleep(100);
                    try
                    {
                        string options = "";

                        options = MakeNUnitOptions(ref options);

                        string strOld;
                        string strPattern;
                        MakeXSLRule(out strOld, out strPattern);

                        DeleteOldResult();

                        RunNUnit(options);

                        CreateResultFile(strOld, strPattern);

                        OpenResultFile();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Во время запуска тестов произошла ошибка.\n" + err.Message,
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return result;
                });

            ProgressBar.Visible = false;
            btSubmit.Enabled = true;
            Refresh();
        }

        private void DeleteOldResult()
        {
            if (System.IO.File.Exists(@resultName))
            {
                try
                {
                    System.IO.File.Delete(@resultName);
                }
                catch (System.IO.IOException e)
                {
                    /*MessageBox.Show("Невозможно удалить старый фалй с данными.\n" + e.Message, 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                    return;
                }
            }
        }

        private void OpenResultFile()
        {
            //open new result xml with xsl
            TestExecute execBrowser = new TestExecute();
            execBrowser.runTest(resultNewName, "", false);
        }

        private void CreateResultFile(string strOld, string strPattern)
        {
            //read xml all
            //input xsl string to xml
            TestReadWriteXMLString wr = new TestReadWriteXMLString();

            string pref = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() +
                "(" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ")";
            wr.readwriteXmlToString(resultName, strOld, strPattern, pref + resultName);
            resultNewName = pref + resultName;
        }

        private void RunNUnit(string options)
        {
            //run Nunit
            //Make sure, that Nunit or nunit-console makes result files default
            TestExecute exec = new TestExecute();
            exec.runTest(tbNUnit.Text, tbdll.Text + " " + options, true);
        }

        private void MakeXSLRule(out string strOld, out string strPattern)
        {
            //make path without name of file
            strOld = "<!--This file represents the results of running a test suite-->";
            strPattern = "<?xml-stylesheet type='text/xsl' href='" +
                tbXSL.Text + "'?>" +
                "\n" + strOld;
        }

        private string MakeNUnitOptions(ref string options)
        {
            //Make options to NUnit
            if (cblbTree.Items.Count == cblbTree.CheckedItems.Count)
                options = "";
            else
            {
                options = "" + "/run:";
                foreach (string s in cblbTree.CheckedItems)
                {
                    options += className + "." + s + ",";
                }
                //MessageBox.Show(options);
            }
            return options;
        }

        private void ReadDll(string filename)
        {
            if (filename.Length != 0)
            {
                ClearGUIData();

                Reflector r = new Reflector();
                if (!r.GetMethods(filename, list, ref className))
                    MessageBox.Show("Ошибка при построении дерева методов.\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } //if
        }

        private void MakeTree(string fileName)
        {
            ClearInputData();
            ReadDll(fileName);

            ClearGUIData();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    cblbTree.Items.Add(list[i]);//, CheckState.Checked);
                }
            }
            else
            {
                MessageBox.Show("Нет доступных тестов.\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputData()
        {
            list.Clear();
            className = "";
        }

        private void ClearGUIData()
        {
            cblbTree.Items.Clear();
            //className = "";
        }

        private void btDll_Click(object sender, EventArgs e)
        {
            if (ofdDll.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbdll.Text = ofdDll.FileName;
                    //makeTree(ofdDll.FileName);
                }
                catch (Exception ex)
                {
                    tbdll.Text = "";
                    MessageBox.Show("Hе возможно считать файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Refresh();
        }

        private void btWatch_Click(object sender, EventArgs e)
        {
            //open new result xml with xsl
            TestExecute execBrowser = new TestExecute();
            execBrowser.runTest(resultNewName, "", false);
        }

        private void btCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ограничения:
        /// 1) Работает только с 1 dll (исправить! использовать list)
        /// 2) Работает только с 1 классом тестов в dll 
        /// (исправить! использовать list<list<Object(clas,methods)>>)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDefault_Click(object sender, EventArgs e)
        {
            //Атрибут для идентификации начала данных в XML
            string fileheader = "/config";
            //Атрибут для идентификации пути к nunit
            string nunit = "path-nunit";
            //Атрибут для идентификации пути к xsl для преобразования xml
            string xsl = "path-xsl";
            //Атрибут для идентификации сборки dll для загрузки
            string dll = "path-dll";
            //Атрибут для имени файла с результатами XML
            string xml = "name-xml";

            if (tbConfig.Text != "")
            {
                try
                {
                    XmlDocument rdr = new XmlDocument();
                    rdr.Load(@tbConfig.Text); // Загрузка XML

                    XmlNode xmlData = rdr.SelectSingleNode(fileheader);

                    tbdll.Text = xmlData[dll].InnerText;
                    //makeTree(tbdll.Text);
                    tbNUnit.Text = xmlData[nunit].InnerText;
                    tbXSL.Text = xmlData[xsl].InnerText;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Проблемы с парсингом файла config.xml.\n" + exp.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Укажите имя файла с настройками.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (tbdll.Text != "" && tbNUnit.Text != "")
                btSubmit.Enabled = true;
            else
                btSubmit.Enabled = false;

            if (tbXSL.Text != "")
                btWatch.Enabled = true;
            else
                btWatch.Enabled = false;
        }

        private void btNUnit_Click(object sender, EventArgs e)
        {
            if (ofdNUnit.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbNUnit.Text = ofdNUnit.FileName;
                }
                catch (Exception ex)
                {
                    tbNUnit.Text = "";
                    MessageBox.Show("Hе возможно считать файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Refresh();
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            if (ofdConfig.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbConfig.Text = ofdConfig.FileName;
                }
                catch (Exception ex)
                {
                    tbConfig.Text = "";
                    MessageBox.Show("Hе возможно считать файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Refresh();
        }

        private void btXSL_Click(object sender, EventArgs e)
        {
            if (ofdXSL.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbXSL.Text = ofdXSL.FileName;
                }
                catch (Exception ex)
                {
                    tbXSL.Text = "";
                    MessageBox.Show("Hе возможно считать файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Refresh();
        }

        private void btCheckedAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblbTree.Items.Count; ++i)
            {
                cblbTree.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void tbdll_TextChanged(object sender, EventArgs e)
        {            
            //срабатывает толкьо если текст реально поменялся, 
            //если же загрузили тот же файл, то дерево не меняется
            //Проблемы если за это время изменился dll файл
            //Возможно лучше вызывать makeTree в каждом методе где надо менять дерево
            if (tbdll.Text != "")
            {
                MakeTree(tbdll.Text);
                Refresh();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            Refresh();
        }

        private void btClearChecked_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblbTree.Items.Count; ++i)
            {
                cblbTree.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (cblbTree.CheckedItems.Count > 0)
            {
                try
                {
                    if (sfdSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        Stream myStream;
                        if ((myStream = sfdSaveFile.OpenFile()) != null)
                        {
                            // Code to write the stream goes here.
                            System.IO.StreamWriter sw = new System.IO.StreamWriter(myStream);
                            foreach (string s in cblbTree.CheckedItems)
                            {
                                sw.WriteLine(className + "." + s);
                            }
                            sw.Flush();
                            sw.Close();
                            myStream.Close();
                        }
                        MessageBox.Show("Данные сохранены.\n",
                            "Информационное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Ошибка при сохранении.\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Нечего сохранять.\n",
                    "Информационное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (ofdOpenSavedFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream;
                    if ((myStream = ofdOpenSavedFile.OpenFile()) != null)
                    {
                        System.IO.StreamReader sr = new System.IO.StreamReader(myStream);
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            for ( int i = 0; i < cblbTree.Items.Count; ++i )
                            {
                                string treeLine = className + "." + cblbTree.Items[i].ToString();
                                if (line == treeLine)
                                {
                                    cblbTree.SetItemCheckState(i, CheckState.Checked);
                                    continue;
                                }
                            }
                        }
                        sr.Close();
                        myStream.Close();
                    }
                    MessageBox.Show("Данные считаны.\n",
                        "Информационное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    tbdll.Text = "";
                    MessageBox.Show("Hе возможно считать файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить файл?", "Подтверждение удаления файла",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(@resultNewName);
                    MessageBox.Show("Файл удален.", "Инофрмационное сообщение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException err)
                {
                    MessageBox.Show("Произошла ошибка во время удаления файл " +
                                    resultNewName + ": \n" +
                                    err.Message, "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

