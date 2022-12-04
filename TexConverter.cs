using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDXViewer
{
    internal class TexConverter
    {
        public static readonly ProcessStartInfo texConvInfo = new ProcessStartInfo
        {
            UseShellExecute = true,
            FileName = MainForm.texConvPath,
            WindowStyle = ProcessWindowStyle.Hidden
        };
        public static readonly Process texConv = new Process { StartInfo = texConvInfo, EnableRaisingEvents = true };

        public static void ConvertToPng(string file, string output)
        {
            texConvInfo.Arguments = $"\"{file}\" -ft png -y -o \"{output}\"";

            texConv.Start();
            texConv.WaitForExit();

            if (texConv.ExitCode != 0)
            {
                MessageBox.Show("An error occured while converting the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public static void ConvertToDDS(string file, string output)
        {
            texConv.StartInfo.Arguments = $"\"{file}\" -r:keep -f BC7_UNORM -bc x -if POINT -ft dds -fl 11.0 -tu -m 1 -y -o \"{Path.GetDirectoryName(output)}\"";

            texConv.Start();
            texConv.WaitForExit();

            if (texConv.ExitCode != 0)
            {
                MessageBox.Show("An error occured while converting the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
