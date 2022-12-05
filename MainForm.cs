using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DDXViewer
{
    public partial class MainForm : Form
    {
        private static readonly string exePath = Assembly.GetExecutingAssembly().Location;
        private static readonly string exeDirectory = Path.GetDirectoryName(exePath);
        private static readonly string resourcesPath = $@"{exeDirectory}\Resources";
        private static readonly string dependenciesPath = $@"{exeDirectory}\Dependencies";
        public static readonly string texConvPath = $@"{dependenciesPath}\texconv.exe";
        private static string originalFilePath;
        private static string resourceFilePath;
        private static string resourceFileName;
        private static string resourceFileConvertedPath;
        private readonly string[] arguments;

        public MainForm(string[] args)
        {
            InitializeComponent();
            FileExtension.RegisterForFileExtension(".ddx", Application.ExecutablePath);

            arguments = args;

            if (arguments.Length > 1)
            {
                CheckExtension(arguments[1], ".ddx");
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void CheckExtension(string file, string ext)
        {
            if (!file.EndsWith(ext))
            {
                MessageBox.Show($"The input file must be a {ext} file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            CopyToResource(arguments[1]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => CleanUp();

        private void CopyToResource(string path)
        {
            originalFilePath = path;
            resourceFileName = Path.GetFileNameWithoutExtension(originalFilePath);
            resourceFilePath = $@"{resourcesPath}\{resourceFileName}.dds";
            Text = $"DDXViewer - {resourceFileName}";

            if (!File.Exists(resourceFilePath))
            {
                File.Copy(originalFilePath, resourceFilePath);
            }

            ConvertResourceImage();
        }

        private void ConvertResourceImage()
        {
            TexConverter.ConvertToPng(resourceFilePath, resourcesPath);

            if (File.Exists(resourceFilePath))
            {
                File.Delete(resourceFilePath);
            }

            resourceFileConvertedPath = $@"{resourcesPath}\{resourceFileName}.png";

            DisplayConvertedImage();
        }

        private Image displayImage;

        private void DisplayConvertedImage()
        {
            if (File.Exists(resourceFileConvertedPath))
            {
                displayImage = Image.FromFile(resourceFileConvertedPath);
                DisplayBox.Image = displayImage;
            }
            else
            {
                MessageBox.Show("An error occured while converting the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            Size = displayImage.Size;
        }

        private void CleanUp()
        {
            displayImage?.Dispose();
            DisplayBox?.Dispose();

            foreach (string file in Directory.GetFiles(resourcesPath))
            {
                File.Delete(file);
            }

            TexConverter.texConv?.Dispose();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            pe.Graphics.SmoothingMode = SmoothingMode.None;
            base.OnPaint(pe);
        }
    }
}