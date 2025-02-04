namespace GPAX
{
    public partial class Form1 : Form
    {
        GPAXCalculator gPAXCalculator;
        public Form1()
        {
            gPAXCalculator = new GPAXCalculator();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(score_TB.Text);
                gPAXCalculator.setGPA(input);
                this.Gpax_TB.Text = gPAXCalculator.getGPAX().ToString();
                this.MaxSC_TB.Text = gPAXCalculator.getMax().ToString();
                this.MinSC_TB.Text = gPAXCalculator.getMin().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("กรุณาใส่ตัวเลขด้วยครับ/ค่ะ");
                this.score_TB.Text = string.Empty;
            }




        }
    }
}
