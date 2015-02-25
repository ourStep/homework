using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_lesson_2_7
{
    public class Student
    {
        private string _name;
        private string _patronymic;
        private string _surname;
        private string _group;
        private int _age;
        private int[][] _mark;

        
        public Student(string name = null, string patronymic = null, string surname = null)
        {
            _name = name;
            _patronymic = patronymic;
            _surname = surname;
            _group = null;
            _age = 0;
           
            _mark = new int[3][];
            _mark[0] = new int[0];     //оценки по программированию
            _mark[1] = new int[0];     //оценки по администрированию
            _mark[2] = new int[0];     //оценки по дизайну          
        }

        public void print()
        {
            Console.WriteLine("student`s data:" );
            Console.WriteLine("{0} {1} {2}", _name, _patronymic, _surname);
            Console.WriteLine("group - {0}, age - {1}", _group, _age);
            Console.WriteLine("Marks:");
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < _mark[i].Length; ++j)
                {
                    Console.Write(_mark[i][j] + " ");
                }
                switch (i)
                {
                    case 0:
                        Console.WriteLine("\t Average mark for programming = {0}", GetAverageMark(i));
                        break;
                    case 1:
                        Console.WriteLine("\t Average mark for administration = {0}", GetAverageMark(i));
                        break;
                    case 2:
                        Console.WriteLine("\t Average mark for design = {0}", GetAverageMark(i));
                        break;
                }
            }
        }

        public float GetAverageMark(int subj)
        {
            int sum = 0;
            for (int i = 0; i < _mark[subj].Length; ++i)
            {
                sum += _mark[subj][i];
            }
            return (float)sum / _mark[subj].Length;
        }
        
        public int GetMark(int index, int subj)
        {
           return _mark[subj][index];            
        }

        public void SetMarksArray(ref int[] arr, int subj)
        {
            Array.Resize(ref _mark[subj], arr.Length);
            for (int i = 0; i < arr.Length; ++i)
            {
                _mark[subj][i] = arr[i];
            }                
        }


        public void AddMark(int mark, int subj)
        {
           Array.Resize(ref _mark[subj], _mark[subj].Length + 1);
           _mark[subj][_mark[subj].Length - 1] = mark;
        }
           
        
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return this._patronymic;
            }
            set
            {
                this._patronymic = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}
