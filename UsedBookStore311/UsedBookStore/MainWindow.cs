﻿using System;
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
          public frmMainWindow()
          {
               InitializeComponent();
               Controller controller = new Controller();
               controller.connectDB();
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
     }
}
