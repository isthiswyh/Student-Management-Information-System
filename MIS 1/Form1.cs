using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MIS
{
    
    public partial class Form1 : Form
    {
        public static Form1 A = null;          
        public static List<Person> alldata = new List<Person>();
        List<Person> selectedPerson = new List<Person>();
        string txtFilePath;
        public Form1()
        {
            A = this;
            InitializeComponent();
        }
        
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_添加_Click(object sender, EventArgs e)
        {
            if (tb_学号.Text == "" || tb_姓名.Text == "" || tb_课程名.Text == "" || tb_分数.Text == "")
            {
                MessageBox.Show("信息不能为空!");
                return;
            }
            Person person = new Person();
            person.Id = tb_学号.Text;
            person.Name = tb_姓名.Text;
            person.Lesson = tb_课程名.Text;
            person.Grade = tb_分数.Text;
            alldata.Add(person);
            AppendOnePerson(txtFilePath, person);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
        }

        private void btn_删除_Click(object sender, EventArgs e)
        {
            //判断是否选中一行
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("请选择您要删除的一行！");
                return;

            }
            //从集合中将对应的对象删除
            for (int i = 0; i < alldata.Count; i++)
            {
                if (alldata[i].Id == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    alldata.RemoveAt(i);
                    break;

                }
            }
            //重新绑定数据
            Save(txtFilePath);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
            // 重新导出txt
            MessageBox.Show("删除成功");

        }

        private void btn_修改_Click(object sender, EventArgs e)
        {
            //判断是否选中要修改的一行
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("请您选择一行数据！");
                return;

            }
            //对集合中对应的数据进行修改
            for (int i = 0; i < alldata.Count; i++)
            {
                if (alldata[i].Id == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    dataGridView1.SelectedRows[0].Cells["id"].Value = tb_学号.Text;
                    dataGridView1.SelectedRows[0].Cells["name"].Value = tb_姓名.Text;
                    dataGridView1.SelectedRows[0].Cells["lesson"].Value = tb_课程名.Text;
                    dataGridView1.SelectedRows[0].Cells["grade"].Value = tb_分数.Text;
                    alldata[i].Id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                    alldata[i].Name = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                    alldata[i].Lesson = dataGridView1.SelectedRows[0].Cells["lesson"].Value.ToString();
                    alldata[i].Grade = dataGridView1.SelectedRows[0].Cells["grade"].Value.ToString();
                    break;
                }
            }



            //数据重新绑定
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
            Save(txtFilePath);
            MessageBox.Show("修改成功！");


        }

        private void btn_保存_Click(object sender, EventArgs e)
        {
            Save(txtFilePath);
            MessageBox.Show("保存成功！");

        }
        private void Save(string strFilePath)
        {
            //1.首先查看是否有需要保存的数据
            if (alldata == null)
            {
                return;
            }
            //3.开始写入txt
            FileStream FS = new FileStream(strFilePath, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter SW = new StreamWriter(FS);
            for (int i = 0; i < alldata.Count; i++)
            {
                //去掉最后那个“#”
                SW.WriteLine(alldata[i].Id + "#" + alldata[i].Name + "#" + alldata[i].Lesson +
                    "#" + alldata[i].Grade);
            }
            SW.Close();
            FS.Close();

        }

        private void AppendOnePerson(string strFilePath, Person person)
        {

            //3.开始写入txt
            FileStream FS = new FileStream(strFilePath, FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);
            SW.WriteLine(person.Id + "#" + person.Name + "#" + person.Lesson + "#" + person.Grade);
            SW.Close();
            FS.Close();
            MessageBox.Show("追加成功！");

        }
        public List<Person> Select(string ID)
        {
            foreach (Person pr in alldata)
            {

                if (pr.Id == ID)
                {
                    selectedPerson.Add(pr);
                }
            }
            return selectedPerson;
        }
        public void ReadDataToPersons(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;

            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                Person newPerson = new Person();
                string[] oneLine = strLine.Split('#');
                newPerson.Id = oneLine[0];
                newPerson.Name = oneLine[1];
                newPerson.Lesson = oneLine[2];
                newPerson.Grade = oneLine[3];
                alldata.Add(newPerson);
            }
            SR.Close();
            FS.Close();
        }


        private void tbn_select_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Select(tb_学号.Text);
        }

        private void tbn_selectall(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
        }

        private void tbn_load(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "文本文件(txt)|*.txt";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath = opd.FileName;
            }
            ReadDataToPersons(txtFilePath);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
        }

        private void tb_学号_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shengxu(txtFilePath);
        }
        // int[] array=new int[dataGridView1.RowCount];
        //dataGridView1.CurrentCell=dataGridView1[3,0];
        //  int temp;
        /// for (int i = 0; i < dataGridView1.RowCount; i++)
        // array[i] = int.Parse(dataGridView1[3, i].Value.ToString());
        //  for (int a = 0; a < array.Length - 1; a++)
        //{
        //   for (int b = 0; b < array.Length - 1 - a; b++)
        // {
        //     if (array[b] < array[b + 1])
        //  {
        //    temp = array[b];
        //   array[b] = array[b + 1];
        //    array[b + 1] = temp;
        //   }
        //  }
        //     }
        // for(int c=0;c<=array.Length-1;c++)
        //  {
        //   for(int d=0;d<dataGridView1.RowCount;d++)
        //  {
        //    if(array[c]==int.Parse(dataGridView1[3,d].Value.ToString()))
        //   this.dataGridView1.CurrentRow=this.dataGridView1
        public void shengxu1(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;
            Person[] array = new Person[alldata.Count];
            int i = 0;
            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                string[] oneLine = strLine.Split('#');
                array[i] = new Person();
                array[i].Id = oneLine[0];
                array[i].Name = oneLine[1];
                array[i].Lesson = oneLine[2];
                array[i].Grade = oneLine[3];
                i++;
            }
            Person temp = new Person();
            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = 0; b < array.Length - 1 - a; b++)
                {
                    if (int.Parse(array[b].Id) > int.Parse(array[b + 1].Id))
                    {
                        temp = array[b];
                        array[b] = array[b + 1];
                        array[b + 1] = temp;
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = array;
        }
        public void shengxu(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;
            Person[] array = new Person[alldata.Count];
            int i = 0;
            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                string[] oneLine = strLine.Split('#');
                array[i] = new Person();
                array[i].Id = oneLine[0];
                array[i].Name = oneLine[1];
                array[i].Lesson = oneLine[2];
                array[i].Grade = oneLine[3];
                i++;
            }
            Person temp = new Person();
            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = 0; b < array.Length - 1 - a; b++)
                {
                    if (int.Parse(array[b].Grade) > int.Parse(array[b + 1].Grade))
                    {
                        temp = array[b];
                        array[b] = array[b + 1];
                        array[b + 1] = temp;
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = array;
        }
        public void jiangxu(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;
            Person[] array = new Person[alldata.Count];
            int i = 0;
            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                string[] oneLine = strLine.Split('#');
                array[i] = new Person();
                array[i].Id = oneLine[0];
                array[i].Name = oneLine[1];
                array[i].Lesson = oneLine[2];
                array[i].Grade = oneLine[3];
                i++;
            }
            Person temp = new Person();
            for (int a = 0; a < array.Length - 1; a++)
            {
                for (int b = 0; b < array.Length - 1 - a; b++)
                {
                    if (int.Parse(array[b].Grade) < int.Parse(array[b + 1].Grade))
                    {
                        temp = array[b];
                        array[b] = array[b + 1];
                        array[b + 1] = temp;
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = array;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 1)
            {
                MessageBox.Show("请您选择某一单元格数据！");
                return;

            }
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                dataGridView1.CurrentCell.Value = tb_学号.Text;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                dataGridView1.CurrentCell.Value = tb_姓名.Text;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                dataGridView1.CurrentCell.Value = tb_课程名.Text;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                dataGridView1.CurrentCell.Value = tb_分数.Text;
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
        }


        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "文本文件(txt)|*.txt";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath = opd.FileName;
            }
            ReadDataToPersons(txtFilePath);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void 保存为txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string savefile = @"c:\学生信息.txt";
            SaveFileDialog opd = new SaveFileDialog();
            opd.Filter = "文本文件(txt)|*.txt";
            opd.FilterIndex = 0;
            opd.RestoreDirectory = true;
            opd.CreatePrompt = true;
            opd.Title = "另存信息";
            opd.ShowDialog();          
            Stream mystream;
            try
            {
                mystream = opd.OpenFile();
            }
            catch { return; }
            StreamWriter SW = new StreamWriter(mystream,System.Text.Encoding.GetEncoding(-0));
            string str = "";
            try
            {
                for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
                {
                    if (i > 1)
                    {
                        str += "\t";
                    }
                    str += this.dataGridView1.Columns[i].HeaderText;
                }
                SW.WriteLine(str);
                for (int j = 0; j < this.dataGridView1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 1; k < this.dataGridView1.Columns.Count; k++)
                    {
                        if (k > 1)
                        {
                            tempStr += "/t";
                        }
                        tempStr += this.dataGridView1.Rows[j].Cells[k].Value.ToString();
                    }
                    SW.WriteLine(tempStr);
                }

                SW.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SW.Close();
                mystream.Close();
            }
        }

        private void 保存为excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string savefile = @"c:\学生信息.txt";
            SaveFileDialog opd = new SaveFileDialog();
            opd.Filter = "Excel工作表(*.xls)|*.xls";
            opd.FilterIndex = 0;
            opd.RestoreDirectory = true;
            opd.CreatePrompt = true;
            opd.Title = "另存信息";
            opd.ShowDialog();
            Stream mystream;
            try
            {
                mystream = opd.OpenFile();
            }
            catch { return; }
            StreamWriter SW = new StreamWriter(mystream, System.Text.Encoding.GetEncoding(-0));
            string str = "";
            try
            {
                for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
                {
                    if (i > 1)
                    {
                        str += "\t";
                    }
                    str += this.dataGridView1.Columns[i].HeaderText;
                }
                SW.WriteLine(str);
                for (int j = 0; j < this.dataGridView1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 1; k < this.dataGridView1.Columns.Count; k++)
                    {
                        if (k > 1)
                        {
                            tempStr += "/t";
                        }
                        tempStr += this.dataGridView1.Rows[j].Cells[k].Value.ToString();
                    }
                    SW.WriteLine(tempStr);
                }

                SW.Close();
                mystream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SW.Close();
                mystream.Close();
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tb_学号.Text == "" || tb_姓名.Text == "" || tb_课程名.Text == "" || tb_分数.Text == "")
            {
                MessageBox.Show("信息不能为空!");
                return;
            }
            Person person = new Person();
            person.Id = tb_学号.Text;
            person.Name = tb_姓名.Text;
            person.Lesson = tb_课程名.Text;
            person.Grade = tb_分数.Text;
            alldata.Add(person);
            AppendOnePerson(txtFilePath, person);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alldata;
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否选中要修改的一行
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("请您选择一行数据！");
                return;

            }
            //对集合中对应的数据进行修改
            for (int i = 0; i < alldata.Count; i++)
            {
                if (alldata[i].Id == dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
                {
                    dataGridView1.SelectedRows[0].Cells["id"].Value = tb_学号.Text;
                    dataGridView1.SelectedRows[0].Cells["name"].Value = tb_姓名.Text;
                    dataGridView1.SelectedRows[0].Cells["lesson"].Value = tb_课程名.Text;
                    dataGridView1.SelectedRows[0].Cells["grade"].Value = tb_分数.Text;
                    alldata[i].Id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                    alldata[i].Name = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                    alldata[i].Lesson = dataGridView1.SelectedRows[0].Cells["lesson"].Value.ToString();
                    alldata[i].Grade = dataGridView1.SelectedRows[0].Cells["grade"].Value.ToString();
                    break;
                }
            }
        }

        private void 修改某单元格数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 1)
            {
                MessageBox.Show("请您选择某一单元格数据！");
                return;

            }
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                dataGridView1.CurrentCell.Value = tb_学号.Text;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                dataGridView1.CurrentCell.Value = tb_姓名.Text;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                dataGridView1.CurrentCell.Value = tb_课程名.Text;
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                dataGridView1.CurrentCell.Value = tb_分数.Text;
            }

        }

        private void 按成绩升序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shengxu(txtFilePath);
        }

        private void 按成绩降序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jiangxu(txtFilePath);
        }

        private void 按学号排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shengxu1(txtFilePath);
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 按学号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Select(tb_学号.Text);
        }

        private void 按姓名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Select(tb_姓名.Text);
        }

        private void 按成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Select(tb_分数.Text);
        }

        private void 按课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Select(tb_课程名.Text);
        }

        private void 标准之上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            if (this.Visible == false)
            shaixuan标准之上(txtFilePath);
            
        }
        private void 标准之下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            if (this.Visible == true)
            { shaixuan标准之下(txtFilePath); }
        }
        public void shaixuan标准之上(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;
            Person[] array = new Person[alldata.Count];
            int i = 0;
            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                string[] oneLine = strLine.Split('#');
                array[i] = new Person();
                array[i].Id = oneLine[0];
                array[i].Name = oneLine[1];
                array[i].Lesson = oneLine[2];
                array[i].Grade = oneLine[3];
                i++;
            }
            
            Form2 f2=new Form2();
            List<Person>list=array.ToList();
            for (int a = 0; a < array.Length ; a++)
            {
                if(int.Parse(list[a].Grade)<int.Parse(f2.form2))
                {
                    list.RemoveAt(a);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = array;
            }
        }
        public void shaixuan标准之下(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;
            Person[] array = new Person[alldata.Count];
            int i = 0;
            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                string[] oneLine = strLine.Split('#');
                array[i] = new Person();
                array[i].Id = oneLine[0];
                array[i].Name = oneLine[1];
                array[i].Lesson = oneLine[2];
                array[i].Grade = oneLine[3];
                i++;
            }

            Form2 f2 = new Form2();
            List<Person> list = array.ToList();
            for (int a = 0; a < array.Length; a++)
            {
                if (int.Parse(list[i].Grade) >int.Parse(f2.form2))
                {
                    list.RemoveAt(i);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = array;
            }
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            if (this.Visible == true)
                tianjia(txtFilePath);
        }
        public void tianjia(string strFilePath)
        {
            FileStream FS = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FS);
            string strLine;
            Person[] array = new Person[alldata.Count];
            int i = 0;
            while ((strLine = SR.ReadLine()) != null)
            {
                //去掉最后那个“#”
                string[] oneLine = strLine.Split('#');
                array[i] = new Person();
                array[i].Id = oneLine[0];
                array[i].Name = oneLine[1];
                array[i].Lesson = oneLine[2];
                array[i].Grade = oneLine[3];
                i++;
            }

            Form3 f3 = new Form3();
            
            for (int a = 0; a < array.Length; a++)
            {
                if(array[a].Name==f3.a.ToString())
                    array[a].Tele=f3.b;
                    array[a].Email=f3.c;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = array;
            }

        private void 冻结行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Frozen= true;
        }

        private void 全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void 某行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.ReadOnly = true;
        }

        private void 隐藏行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Visible = false;
        }

        private void 帮助和关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void 设置为只读ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 冻结列ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }


