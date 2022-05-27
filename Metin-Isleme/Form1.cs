using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Isleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Stack Stack_Sentences;
        Stack Stack_Words;
        Stack Stack_PWords;
        Stack Stack_UniqueWords;
        Heap HeapTree; 
        HashTable HashTable_;
        public void btnMetinYukle_Click(object sender, EventArgs e)
        {
            btnStackAktar.Enabled = true;
            rtxtFile.Clear();
            rtxtFileValues.Clear();
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    rtxtFile.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        rtxtFileValues.Text = fileContent;
                    }
                }
            }





        }

        private void btnStackAktar_Click(object sender, EventArgs e)
        {
            btnHeapTransfer.Enabled = true;

            Stack_Sentences = new Stack();
            Stack_Words = new Stack();
            Stack_PWords = new Stack();
            Stack_UniqueWords = new Stack();
            txtSentences.Clear();
            txtWords.Clear();
            string[] sentences = rtxtFileValues.Text.Split("\n");
            int totalSentences = 0;
            float avgWordQuantity = 0;
            int totalWordQuantity = 0;
            int sayac = 1;
            foreach (var sentence_item in sentences)
            {
                totalSentences++;
                Node nodeSentence = new Node(sentence_item);
                foreach (var word_item in sentence_item.Split(" "))
                {
                    totalWordQuantity++;
                    Stack_Words.Push(sayac,Stack_Sentences.Count,word_item);
                    Node nodeWord = new Node(sayac, Stack_Sentences.Count, word_item);
                    nodeSentence.WordQuantity++;
                    Stack_PWords.Push(sayac, Stack_Sentences.Count, nodeWord.Processed_word);

                    if (!nodeWord.DuplicateControl(Stack_UniqueWords,nodeWord.Processed_word.ToLower()))
                    {
                        Stack_UniqueWords.Push(0,0,nodeWord.Processed_word.ToLower());
                    }
                    sayac++;
                }
                Stack_Sentences.Push(nodeSentence);
                txtSentences.Text += sentence_item + " /Kelime Sayisi: " + nodeSentence.WordQuantity.ToString() + Environment.NewLine;
            }
            foreach (var item in Stack_UniqueWords.DispElement())
            {
                if (item.Value == "")
                {
                    continue;
                }
                txtWords.Text += item.Value + " /Frekans: " + item.frekans + Environment.NewLine;
            }

            avgWordQuantity = totalWordQuantity / totalSentences;
            txtGeneralValues.Text += "Toplam Cümle Sayisi: " + totalSentences.ToString() + Environment.NewLine ;
            txtGeneralValues.Text += "Ortalama Kelime Sayisi: " + avgWordQuantity.ToString(); 

        }


        Stack Stack_Temp;
        private void btnHeapTransfer_Click(object sender, EventArgs e)
        {
            btnWordSort.Enabled = true;

            Stack_Temp = new Stack();
            HeapTree = new Heap(Stack_UniqueWords.Count);
            

            foreach (var item in Stack_UniqueWords.DispElement())
            {
                HeapTree.Insert(item);
            }



        }




        private void btnWordSort_Click(object sender, EventArgs e)
        {
            btnHash.Enabled = true;

            txtHeapValues.Clear();
            HeapNode[] sorted = HeapTree.Sort();
            for (int i = 0; i < Convert.ToInt32(txtCount.Text); i++)
            {
                txtHeapValues.Text += "Kelime: " + sorted[i].Data.Value + " /Frekans: " + sorted[i].Data.frekans.ToString() + Environment.NewLine;
            }
        }
        //HeapTree.heapArray[i].Data.Value
        
        private void btnHash_Click(object sender, EventArgs e)
        {
            Stack_Temp = new Stack();
            HashTable_ = new HashTable(5);
            //Stack_UniqueWords.Count

            foreach (var item in Stack_UniqueWords.DispElement())
            {
                HashTable_.InsertHashedValue(item.Value);
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
