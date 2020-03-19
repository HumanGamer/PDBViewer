using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBViewer
{
	public class PDBFile
	{
		public PDBFile()
		{

		}

		public static PDBFile ReadPDBFile(string path)
		{
			PDBFile pdb = new PDBFile();
			if (!pdb.Read(path))
				return null;

			return pdb;
		}

		private bool Read(string path)
		{
			using (Stream s = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (BinaryReader br = new BinaryReader(s))
			{
				// TODO: Read File
			}

			return true;
		}
	}
}
