using System;
using System.Windows.Forms;
using System.Security.Principal;

namespace SecureButton
{
    public partial class SecureButtonTest : Form
    {
        public SecureButtonTest()
        {
            InitializeComponent();
        }

        private void SecureButtonTest_Load(object sender, EventArgs e)
        {
            // Get the user's identity.
            WindowsIdentity myIdentity = 
                WindowsIdentity.GetCurrent();

            // Obtain information about the user's rights.
            WindowsPrincipal myPrincipal =
                new WindowsPrincipal(myIdentity);

            // Determine which buttons to show based on
            // the user's rights.
            if (myPrincipal.IsInRole("Accounting"))
                AccountingButton.Visible = true;
            else if (myPrincipal.IsInRole("Sales"))
                SalesButton.Visible = true;
            else if (myPrincipal.IsInRole("Management"))
                ManagerButton.Visible = true;
            else
                MinimalButton.Visible = true;
        }
    }
}
