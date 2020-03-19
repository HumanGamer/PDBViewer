using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDBViewer
{
	public partial class MainForm : Form
	{
		private PDBFile _currentFile;
		private string _currentPath;

		public MainForm()
		{
			InitializeComponent();

			UpdateDisplay();
		}

		private void UpdateDisplay()
		{
			if (_currentFile == null)
			{
				lstMain.Enabled = false;
				return;
			}

			lstMain.Enabled = true;
		}

		private bool Open()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "*.pdb|PDB Files|*.*|All Files";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				return Open(ofd.FileName);
			}

			return false;
		}

		public bool Open(string path)
		{

			PDBFile pdb = PDBFile.ReadPDBFile(path);
			if (pdb == null)
				return false;
			_currentFile = pdb;
			_currentPath = path;
			UpdateDisplay();

			return true;
		}

		private void Exit()
		{
			Application.Exit();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Open();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void tsbOpen_Click(object sender, EventArgs e)
		{
			Open();
		}
	}
}
