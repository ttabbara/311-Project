using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedBookStore
{
     public partial class frmMainWindow : Form
     {
          Controller controller;

          public frmMainWindow(Controller controller)
          {
               InitializeComponent();

               this.controller = controller;
          }

          private void button1_Click(object sender, EventArgs e)
          {

          }

          private void MainWindow_Load(object sender, EventArgs e)
          {

          }

          private void button6_Click(object sender, EventArgs e)
          {

          }

          private void NewListingBtn_Click(object sender, EventArgs e)
          {
              this.controller.showNewListingWindow();
          }
     }
}
