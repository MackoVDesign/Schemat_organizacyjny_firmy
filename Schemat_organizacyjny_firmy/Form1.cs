namespace Schemat_organizacyjny_firmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            odczytzpliku();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zapisdopliku();
            Application.Exit();
        }

        private void dodajGa³¹ŸToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dialog = new Form3();
            dialog.Text = "Dodawanie ga³êzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(dialog.nazwa);
            }
        }

        private void dodajPodga³¹ŸToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dialog = new Form3();
            dialog.Text = "Dodawanie pod ga³êzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(dialog.nazwa);
            }
        }

        private void usuñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void zmieñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dialog = new Form3();
            dialog.Text = "Modyfikowanie ga³êzi";
            dialog.nazwa = treeView1.SelectedNode.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = dialog.nazwa;
            }
        }





        //save file
        public class mynode
        {
            public string rodzic;
            public string nazwa;



            public mynode(string rodzic, string nazwa)
            {
                this.rodzic = rodzic;
                this.nazwa = nazwa;
            }


        }


        private void dodajdolisty(TreeNode node, ref List<mynode> lista)
        {
            if(node == null)
                return;


            string r, n;

            if (node.Parent == null)
            
                r = "brak";
         
            else
           
                r = node.Parent.Text;
                n = node.Text;

            lista.Add(new mynode(r, n));
            if (node.NextNode != null)
                dodajdolisty(node.NextNode, ref lista);
            if (node.GetNodeCount(true) > 0) ;
            dodajdolisty(node.FirstNode, ref lista);
        }
            


        private void zapisdopliku()
        {
            List<mynode> lista = new List<mynode>();
            dodajdolisty(treeView1.Nodes[0], ref lista);
            if (lista.Count == 0)
                return;

            string text = "";
            foreach (mynode elem in lista)
            {
                text += elem.nazwa + " " + elem.rodzic + "\n";
            }
            File.WriteAllText("text.txt", text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Zapisaæ zmiany przed zamknieciem?", "Zamykanie", MessageBoxButtons.YesNoCancel);

            if (res == DialogResult.Yes)
            {
                zapisdopliku();
                Application.Exit();

            }

           else if (res == DialogResult.No)
            {
                Application.Exit();
            }
        }





        private void odczytzpliku()
        {
            treeView1.Nodes.Clear();
            List<mynode> lista = new List<mynode>();
            string[] tab = File.ReadAllLines("text.txt");
            foreach(string elem in tab)
            {
                string[] pom = elem.Split(' ');
                lista.Add(new mynode(pom[1], pom[0]));
            }


            foreach(mynode node in lista)
            {
                if (node.rodzic == "BRAK")
                    treeView1.Nodes.Add(new TreeNode(node.nazwa));

                else
                {
                    TreeNode rodzic = znajdzrodzica(node.rodzic);
                    if (rodzic != null)
                        rodzic.Nodes.Add(node.nazwa);
                }
            }

        }


        private TreeNode znajdzrodzica(string rodzica)
        {
            return null;
        }



    }
}