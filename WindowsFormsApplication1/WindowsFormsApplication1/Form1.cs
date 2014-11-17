using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication1.classes;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable AaaaaMyProperty { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 a;
            loadData();

            DataTable myProperty = AaaaaMyProperty;
            if (myProperty == null)
            {
                return;
            }

            NamaMethod();
        }

        public void NamaMethod()
        {
            int b = 9;

            MessageBox.Show(string.Format("{0} xxxx", b));
        }


        private int loadData()
        {
            try
            {
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            return 0;
        }

        #region fungsi fx

        /// <summary>
        ///     fungsi fx
        /// </summary>
        /// <returns>
        ///     error message from function fx
        /// </returns>
        private string fx()
        {
            string s;

            ////nilai awal
            s = "";

            try
            {
                ////method body
            }
            catch (Exception x)
            {
                s = CommonWebHelper.showExceptionMessage(Response, x);
            }

            return s;
        }

        #endregion

        #region fungsi fx

        private string fx()
        {
            string s;

            ////nilai awal
            s = "";

            return s;
        }

        #endregion
    }
}