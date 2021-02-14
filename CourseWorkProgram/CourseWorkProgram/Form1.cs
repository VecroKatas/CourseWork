using System;
using System.Windows.Forms;

namespace CourseWorkProgram
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int amountAdding = -1, amountDeleting = -1, amountChanging = -1;
		string s;

		private int MAX(int a, int b)//Выбор наибольшего элемента из двух заданных
		{
			return a > b ? a : b;
		}

		private string Reverse(string a)//Разворот заданной строки
		{
			string b = "";

			for (int i = a.Length - 1; i >= 0; i--)
			{
				b += a[i];
			}

			return b;
		}

		private int[,] PairedAmount(string s1, out int paired)//Подсчет кол-ва спаренных элементов
		{
			string s2 = Reverse(s1);
			int i, j;
			int length = s1.Length;
			int[,] c = new int[(length + 1), (length + 1)];//Создание 2д массива для нахождения кол-ва букв в подпоследовательности

			for (i = 1; i <= length; i++)//Подсчет кол-ва букв в подпоследовательности
			{
				for (j = 1; j <= length; j++)
				{
					if (s1[i - 1] == s2[j - 1])
						c[i, j] = c[i - 1, j - 1] + 1;
					else
						c[i, j] = MAX(c[i - 1, j], c[i, j - 1]);
				}
			}

			paired = c[length, length];

			return c;
		}

		private int LCS(string s1, out string output)//Поиск спаренных элементов
		{
			string s2 = Reverse(s1);
			int i, j, k;
			int length = s1.Length;
			int[,] c;

			c = PairedAmount(s1, out  int t);

			char[] outputCH = new char[t];

			for (i = length, j = length, k = t - 1; k >= 0;)//Заполнение массива типа char буквами наибольшей подпоследовательности
			{
				if (s1[i - 1] == s2[j - 1])
				{
					outputCH[k] = s1[i - 1];
					i--;
					j--;
					k--;
				}
				else if (c[i, j - 1] > c[i - 1, j])
					j--;
				else
					i--;
			}

			output = new string(outputCH);//Преобразование массива char в строку

			return t;
		}

		private int Index(string s)//Определение индекса среднего элемента из lcs во всей строке
		{
			LCS(s, out string lcs);

			int index = -1, k = lcs.Length / 2;

			for (int i = 0; i < s.Length; i++)
            {
				if (s[i] == lcs[k])
                {
					index = i;
					return index;
                }
            }

			return index;
		}

		private int UnpairedAmount(string s)//Подсчет кол-ва неспаренных элементов
		{
			return s.Length - LCS(s, out string v);
		}

		private string Deleting(string s)//Создание палиндрома удалением неспаренных элементов
		{
			amountDeleting = LCS(s, out string s1);

			return s1;
		}

		private string AddingUnpairedLCS(string s)//Создание палиндрома добавлением пары для неспаренных элементов, если длина lcs - непарное число
		{
			LCS(s, out string lcs);

			int index = Index(s);

			int j = 0, k = 0;
			int[] indexes = new int[UnpairedAmount(s)];
			string[] letters = new string[UnpairedAmount(s)];

			if (index < s.Length / 2)//Сделать так, чтобы больше всего неспаренных элементов оказалось в левой части (до середины lcs)
			{
				s = Reverse(s);
				index = s.Length - index - 1;
			}

			for (int i = 0; i < s.Length; i++)//Определение индексов неспаренных элементов относительно центра палиндрома
			{
				if (k < lcs.Length)
				{
					if (s[i] == lcs[k])
					{
						k++;
					}
					else
					{
						letters[j] = Convert.ToString(s[i]);
						indexes[j] = i - index;
						j++;
					}
				}
				else
				{
					letters[j] = Convert.ToString(s[i]);
					indexes[j] = i - index;
					j++;
				}
			}

			int minusIndex = -1;
			bool minus = false;

			for (int i = 0; i < letters.Length; i++)//Поиск индекса, чей элемент последний перед центром lcs
			{
				if (indexes[i] <= 0)
				{
					minusIndex = i;
					minus = true;
				}

			}

			int o;

			if (minus)
			{
				for (int i = minusIndex; i >= 0; i--)
				{
					o = 0;
					for (j = minusIndex + 1; j < indexes.Length; j++)
					{
						if (indexes[j] < Math.Abs(indexes[i]))
						{
							o++;
						}
					}

					if (indexes[i] == 0)
					{
						s = s.Insert(index - indexes[i] + o + 2, letters[i]);
					}
					else
					{
						s = s.Insert(index - indexes[i] + o, letters[i]);
					}
				}
			}

			s = Reverse(s);

			index = Index(s);

			string newS = s.Remove(index + 1, s.Length - 1 - index);

			string a = "";

			for (int i = 0; i < newS.Length; i++)
			{
				a += newS[i];
			}

			for (int i = newS.Length - 2; i >= 0; i--)
			{
				a += newS[i];
			}

			return a;
        }

		private string AddingPairedLCS(string s)//Создание палиндрома добавлением пары для неспаренных элементов, если длина lcs - парное число
		{
			LCS(s, out string lcs);

			int index = Index(s);

			int j = 0, k = 0;
			int[] indexes = new int[UnpairedAmount(s)];
			string[] letters = new string[UnpairedAmount(s)];

			if (index < s.Length / 2)
			{
				s = Reverse(s);
				index = s.Length - index - 1;
			}

			for (int i = 0; i < s.Length; i++)
			{
				if (k < lcs.Length)
				{
					if (s[i] == lcs[k])
					{
						k++;
					}
					else
					{
						letters[j] = Convert.ToString(s[i]);
						indexes[j] = i - index;
						j++;
					}
				}
				else
				{
					letters[j] = Convert.ToString(s[i]);
					indexes[j] = i - index;
					j++;
				}
			}

			int minusIndex = -1;
			bool minus = false;

			for (int i = 0; i < letters.Length; i++)
			{
				if (indexes[i] <= 0)
				{
					minusIndex = i;
					minus = true;
				}

			}

			int o;

			if (minus)
			{
				for (int i = minusIndex; i >= 0; i--)
				{
					o = 0;
					for (j = minusIndex + 1; j < indexes.Length; j++)
					{
						if (indexes[j] < Math.Abs(indexes[i]))
						{
							o++;
						}
					}

					if (indexes[i] == 0)
					{
						s = s.Insert(index - indexes[i] + o + 2, letters[i]);
					}
					else
					{
						s = s.Insert(index - indexes[i] + o + 1, letters[i]);
					}
				}
			}

			s = Reverse(s);

			index = Index(s);

			string newS = s.Remove(index + 1, s.Length - 1 - index);

			string a = "";

			for (int i = 0; i < newS.Length; i++)
			{
				a += newS[i];
			}

			for (int i = newS.Length - 3; i >= 0; i--)
			{
				a += newS[i];
			}

			return a;
        }

		private string Adding(string s)//Создание палиндрома добавлением пары для неспаренных элементов
        {
			amountAdding = LCS(s, out string lcs);
			return lcs.Length % 2 == 0 ? AddingPairedLCS(s) : AddingUnpairedLCS(s);
        }

		private string Changing(string s)//Создание палиндрома заменой символов
        {
			char[] ch = s.ToCharArray();
			amountChanging = 0;

			for (int i = 0; i < s.Length; i++)
            {
				if (ch[i] != ch[ch.Length - i - 1])
                {
					ch[ch.Length - i - 1] = ch[i];
					amountChanging++;
                }
            }

			s = new string(ch);
			return s;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			s = textBox1.Text;
			label2.Text = "" + Deleting(s);
			listBox1.Items.Add(Deleting(s) + "  " + UnpairedAmount(s));
		}

        private void button2_Click(object sender, EventArgs e)
        {
			s = textBox1.Text;
			label3.Text = "" + Adding(s);
			listBox1.Items.Add(Adding(s) + "  " + UnpairedAmount(s));
		}

        private void button3_Click(object sender, EventArgs e)
        {
			s = textBox1.Text;
			s = Changing(s);
			listBox1.Items.Add(s + "  " + amountChanging);
			label4.Text = "" + s;
		}

        private void button4_Click(object sender, EventArgs e)
        {
			listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
			s = textBox1.Text;

			amountAdding = UnpairedAmount(s);
			amountDeleting = UnpairedAmount(s);
			Changing(s);
            
			if (amountAdding > amountChanging)
            {
				label5.Text = "Створення паліндрома заміною\nбуде більш оптимально (" + amountChanging + "),\nніж видаленням (" + 
					amountDeleting + ") або\nдодаванням (" + amountAdding + ")";
            }
			else if (amountAdding < amountChanging)
            {
				label5.Text = "Створення паліндрома заміною\nбуде більш оптимально (" + amountChanging + "),\nніж видаленням (" +
					amountDeleting + ") або\nдодаванням (" + amountAdding + ")";
			}
			else
            {
				label5.Text = "Створення паліндрома заміною\nзайме стільки ж дій,\nскільки і видаленням або\nдодаванням (" + amountChanging + ")";
			}
		}

		private void повернутисяНаПочатковуФормуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			Hide();
		}
	}
}