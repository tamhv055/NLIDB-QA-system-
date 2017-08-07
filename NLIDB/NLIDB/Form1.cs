using NLIDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NLIDB
{
    public partial class Form1 : Form
    {
        ConnectProlog connect;
        public string datetime;
        public string SpecificName;
        
        
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Form1()
        {

            connect = new ConnectProlog();
            InitializeComponent();
           
            String FilePath = Environment.CurrentDirectory + @"//QLUV.pl";
            connect.Load_file(FilePath);
     
        }

        int checkDateTime()
        {

            Regex rgx = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");

            string[] sentence = NLquerry_Tb.Text.Split(' ');
            for (int i=0;i<sentence.Count();i++)
            {
                if (rgx.IsMatch(sentence[i]))
                    return i;
            }
            return -1;
        }

        void fineHumanName()
        {
            SpecificName = "";
            string[] sentence = NLquerry_Tb.Text.Split(' ');
            Regex rgx = new Regex(@"[A-Z]");
            for(int i=0;i<sentence.Count();i++)
            {
                if (sentence[i].Any(char.IsUpper))
                    SpecificName += sentence[i] + " "; 
            }
        }

        

        string convertToPLQuerry()
        {

            string sentence=NLquerry_Tb.Text;
            fineHumanName();
            string PLQuerry = "getquery([";
            //Regex rgx = new Regex(@"^[A-Z]([a-zÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+)*( [A-Z]([a-zÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ]+)*)+$");
            if (SpecificName != "")
            {
                sentence = sentence.Replace(SpecificName.Trim(), "specificname");
            }

            if (checkDateTime() > 0)
            {
                string[] s = sentence.Split(' ');
                datetime = s[checkDateTime()];
                sentence = sentence.Replace(datetime.Trim(), "datetime");
            }        
            sentence = sentence.Trim().Replace(' ', ',').ToLower();
         


            
            PLQuerry += sentence + "],S).";
            
            return PLQuerry;
        }


        private void Resuft_Bt_Click(object sender, EventArgs e)
        {
            if (this.NLquerry_Tb.Text != null)
            {
                String s= connect.Query(convertToPLQuerry());
                if(SpecificName != "")
                {
                    s = s.Replace("specificname", SpecificName);
                }
                if (checkDateTime()>0)
                {
                   s = s.Replace("datetime",datetime);
                }
                
                
                this.SQLquerry_Tb.Text = s;
                DataGridView dataGridView1 = new DataGridView();
                panel1.Controls.Add(dataGridView1);               
                dataGridView1.Size = panel1.Size;
                              
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                GetData(s);
            }
            else
            {
                MessageBox.Show("Please enter query !");
            }
        }


        private void GetData(string selectCommand)
        {
            try
            {
               
                String connectionString = @"Data Source=RP7-PC\TAMHV;Initial Catalog=QLUV;Integrated Security=True";

                
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

               
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                try
                {
                    dataAdapter.Fill(table);
                }
                catch(SystemException)
                {
                    MessageBox.Show("câu truy vấn lỗi");
                }
                
                bindingSource1.DataSource = table;
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi SqlQuerry input");
            }
           
            
        }

       
    }
}
