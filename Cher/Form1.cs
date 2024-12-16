namespace Cher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName = "", firstname = "", lastname = "", title = "";
            int x = 0;

            fullName = txtFullname.Text.Trim(); //ลบ spzce หน้าสุดและหลังสุดออก

            //ตรวจสอบว่ามีคำนำหน้าที่ต้องการหรือไม่ (นางสาว, นาง,นาย)
            if (fullName.StartsWith("นางสาว"))
            {
                x = 6;    //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("นาง") || fullName.StartsWith("นาย"))
            {
                x = 3;      //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กชาย"))
            {
                x = 7;      //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กหญิง"))
            {
                x = 8;      //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else
            {
                x = fullName.LastIndexOf('.') + 1;
                title = fullName.Substring(0, x);

            }

            fullName = fullName.Substring(x).Trim();
            //หาตำแหน่งช่องว่างระหว่างชื่อและสกุล
            x = fullName.IndexOf(' ');
            if (x == -1)
            {
                MessageBox.Show("กรุณากรอกชื่อและนามสกุลให้ครบถ้วน", "เกิดขอผิดพลาด");
                return;
            }

            //ตัดตั้งแต่ตัวที่0จนถึงตำแหน่งช่องว่าง
            firstname = fullName.Substring(0, x).Trim();

            //ตัดตั้งแต่ตำแหน่งช่องว่างไปจนหมดข้อความจะได้นามสกุล
            lastname = fullName.Substring(x).Trim();

            //แสดงผลใน Textbox
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm() //คำสั่งเครียหน้าจอ **เอาไว้ใช้ที่อื่นได้**
        {
            txtFullname.Text = "";
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("นายสุริยา คะกะเนปะ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("เด็กชายสุริยา คะกะเนปะ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("นศท.สุริยา คะกะเนปะ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtFullname.Text = ("เด็กหญิงสุริยา คะกะเนปะ");
        }
    }
}
