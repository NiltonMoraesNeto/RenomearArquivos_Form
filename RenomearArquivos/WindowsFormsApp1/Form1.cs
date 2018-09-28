using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnRenomear_Click(object sender, EventArgs e)
        {
            //var dirnames = Directory.GetDirectories(txtCaminho.Text);

            //File.Move(txtAntigo.Text, txtNovo.Text);
            RenomearArquivos();

            MessageBox.Show("SUCESSO");


        }

        private void RenomearArquivos()
        {
            string pasta = txtCaminho.Text + "\\";
            string nomeAntigo = txtAntigo.Text;
            string nomeNovo = txtNovo.Text;

            string folder = pasta;

            if (!Directory.Exists(folder))
            {
                MessageBox.Show("A pasta não existe");
                return;
            }

            string find = nomeAntigo;
            if (string.IsNullOrEmpty(find))
            {
                MessageBox.Show("Nome Antigo não pode ser vazio");
                return;
            }

            string replace = nomeNovo;

            foreach (string file in Directory.GetFiles(folder))
            {
                try
                {
                    File.Move(file, file.Replace(find, replace));
                }
                catch
                {
                    MessageBox.Show("Ops! Não foi possível renomear este arquivo!");
                }
            }
        }



        //private void renomeiaArquivos()
        //{
        //    try
        //    {
        //        // Caminho literal da pasta informada 
        //        DirectoryInfo dirInfo = new DirectoryInfo(txtCaminho.Text);

        //        // Pega todas as informações dos arquivos dentro do diretório informado 
        //        FileInfo[] arquivos = dirInfo.GetFiles();

        //        string antigoNome = txtAntigo.Text;
        //        string novoNome = txtNovo.Text;
        //        int arqAfet = 0, pastasAfet = 0;


        //        for (int i = 0; i < arquivos.Length; i++)
        //        {
        //            if (arquivos[i].Name.Contains(""))
        //            {

        //                //novoNome = @dirInfo + "\\" + arquivos[i].Name.Replace(antigoNome, novoNome);
        //                //System.IO.File.Move((dirInfo + "\\" + antigoNome),(dirInfo + "\\" + novoNome));
        //                arqAfet++;
        //            }
        //        }

        //        MessageBox.Show("OK");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
    }
}
