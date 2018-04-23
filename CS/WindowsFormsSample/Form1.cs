using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;
using System.Reflection;
using System.Threading;

namespace WindowsFormsSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                Parent parent = new Parent();
                parent.Name = i.ToString();
                parentBindingSource.Add(parent);
            }
        }

        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e) {
            e.IsEmpty = false;
        }

        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) {
            e.RelationName = "Children";
        }

        private void gridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) {
            BindingList<Child> details = new BindingList<Child>();
            e.ChildList = details;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync(details);
        }

        void worker_DoWork(object sender, DoWorkEventArgs e) {
            BindingList<Child> details = (BindingList<Child>)e.Argument;
            for (int i = 0; i < 100; i++) {
                BeginInvoke(new MethodInvoker(delegate() {
                    Child child = new Child();
                    child.Name = i.ToString();
                    details.Add(child);
                }));
                Thread.Sleep(1000);
            }
        }
    }
    public class Parent {
        private string _Name;
        public string Name {
            get { return _Name; }
            set {
                _Name = value;
            }
        }
    }
    public class Child {
        private string _Name;
        public string Name {
            get { return _Name; }
            set {
                _Name = value;
            }
        }
    }
}
