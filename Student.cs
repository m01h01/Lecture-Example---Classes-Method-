using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes___Method__
{
    public class Student
    {
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        public Student (string FirstName, string LastName, double CsiGrade, double GenEdGrade)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _csiGrade = CsiGrade;
            _genEdGrade = GenEdGrade;
        }
        public string FirstName
        {
            get{ return _firstName;}
            set{ _firstName = value; }
        }
        public string LastName
        {
            get{return _lastName; }
            set{ _lastName = value; }

        }
        public double CSIGrade
        {
            get{return _csiGrade;}
            set{ _csiGrade = value;}

        }
        public double GENedGrade
        {
            get{return _genEdGrade; }
            set{ _genEdGrade = value; }

        }
        public double GradeAverage()
        {
            return (_csiGrade + _genEdGrade) / 2;
        }
        public override string ToString()
        {
            return $"{this._firstName} {this._lastName}, Csi Grade:{this._csiGrade}" +
                $" - GenEd Grade:{this._genEdGrade} - Average:{GradeAverage()}";
        }

    }
}
