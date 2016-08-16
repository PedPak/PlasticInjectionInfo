using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FarsiDate;

namespace TazrighInfo
{
    public partial class frmOrderAdd : Form
    {
        Order Ord;
        Customer Cs;
        Product Pr;


        public frmOrderAdd()
        {
            InitializeComponent();
        }

        private void frmOrderAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
            
        }

        private void frmOrderAdd_Load(object sender, EventArgs e)
        {
            // initialize Product
            Pr = new Product();
            DataTable dtp = Pr.GetNamesAll();

            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ID";
            cbProduct.DataSource = dtp;    

            // initialize Customers
            Cs = new Customer();
            DataTable dtc = Cs.GetNamesAll();

            cbCustomer.DisplayMember = "FullName";
            cbCustomer.ValueMember = "ID";
            cbCustomer.DataSource = dtc;

            //Set current Date and Times
            string CurrentDate = modDate.FDate(DateTime.Now);
            DateTime CurrentTime=DateTime.Now;
            txtOrderDate.Text = CurrentDate;
            txtDeliverDate.Text = CurrentDate;
            txtStartDate.Text = CurrentDate;
            txtEndDate.Text = CurrentDate;
            txtOrderTime.Text = CurrentTime.Hour.ToString() + ":" + CurrentTime.Minute.ToString();           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cbProduct.SelectedItem.ToString() != "")
            {

                Ord = new Order();
                
                Ord.ProductCode = Convert.ToInt64(cbProduct.SelectedValue);
                Ord.CustomerCode = Convert.ToInt64(cbCustomer.SelectedValue);
                Ord.CastFormatDelivered = chkCastFormatDelivered.Checked;


                long.TryParse(txtProductionCode.Text,out Ord.ProductionCode); 
                int.TryParse(txtNumberofOrder.Text,out Ord.NumberofOrder);
                Single.TryParse(txtMaterialAmount.Text, out Ord.MaterialAmount); 
                Ord.Color = txtColor.Text;
                Single.TryParse(txtColorAmount.Text, out Ord.ColorAmount);
                Ord.ColorOwner = txtColorOwner.Text;
                Ord.MaterialOwner = txtMaterialOwner.Text;
                Ord.OrderDate =  txtOrderDate.Text;
                Ord.OrderTime = txtOrderTime.Text;
                Ord.StartDate = txtStartDate.Text;
                Ord.EndDate = txtEndDate.Text;
                long.TryParse(txtStartCounter.Text, out Ord.StartCounter);
                long.TryParse(txtStopCounter.Text, out Ord.StopCounter);
                Ord.DeliverDate = txtDeliverDate.Text;
                int.TryParse(txtwastedNumber.Text, out Ord.wastedNumber); 
                Single.TryParse(txtWaistedWeight.Text, out Ord.WaistedWeight);
                Single.TryParse(txtWaistedPercent.Text, out Ord.WaistedPercent);
                Single.TryParse(txtTotalProductWeight.Text, out Ord.TotalProductWeight);
                long.TryParse(txtCoinageNumber.Text, out Ord.CoinageNumber);
                Ord.ExperimentLevel = txtExperimentLevel.Text;
                Ord.OperatorName = txtOperatorName.Text;
                Ord.Comments = txtComments.Text;                
                Ord.Purser = txtPurser.Text;    


                

                if (!Ord.Insert()) { MessageBox.Show(Ord.ErrorMessage); return; };

                string msg = "ثبت سفارش {0} و {1} با موفقيت انجام پذيرفت";
                lblMsg.Text = string.Format(msg, cbProduct.SelectedText, cbCustomer.SelectedText);
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show(" نام قطعه بايد تعيين گردد ");
            } 

        }

        private void ClearTextBoxes()
        {
            txtProductionCode.Text = txtNumberofOrder.Text = txtMaterialAmount.Text = txtColor.Text = txtColorAmount.Text = txtColorOwner.Text = txtMaterialOwner.Text = txtStartCounter.Text = txtStopCounter.Text = txtwastedNumber.Text = txtWaistedWeight.Text = txtWaistedPercent.Text = txtCoinageNumber.Text = txtTotalProductWeight.Text = txtExperimentLevel.Text = txtOperatorName.Text = txtComments.Text = txtPurser.Text = "";

            txtOrderDate.Text = txtStartDate.Text = txtEndDate.Text = txtDeliverDate.Text = modDate.FDate(DateTime.Now);
            
            DateTime CurrentTime = DateTime.Now;
            txtOrderTime.Text = CurrentTime.Hour.ToString() + ":" + CurrentTime.Minute.ToString(); 

            chkCastFormatDelivered.Checked = false;

        }

       

       

     
       

        
        
    }
}
