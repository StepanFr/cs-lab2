namespace lab2_2
{

    using System;

    namespace ClassroomExample
    {
        public class Pupil
        {
            public virtual void Study()
            {
                Console.WriteLine("Pupil is studying.");
            }

            public virtual void Read()
            {
                Console.WriteLine("Pupil is reading.");
            }

            public virtual void Write()
            {
                Console.WriteLine("Pupil is writing.");
            }

            public virtual void Relax()
            {
                Console.WriteLine("Pupil is relaxing.");
            }
        }

        public class ExcelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("ExcelentPupil is studying excellently.");
            }

            public override void Read()
            {
                Console.WriteLine("ExcelentPupil is reading excellently.");
            }

            public override void Write()
            {
                Console.WriteLine("ExcelentPupil is writing excellently.");
            }

            public override void Relax()
            {
                Console.WriteLine("ExcelentPupil is relaxing excellently.");
            }
        }

        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("GoodPupil is studying well.");
            }

            public override void Read()
            {
                Console.WriteLine("GoodPupil is reading well.");
            }

            public override void Write()
            {
                Console.WriteLine("GoodPupil is writing well.");
            }

            public override void Relax()
            {
                Console.WriteLine("GoodPupil is relaxing well.");
            }
        }

        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("BadPupil is not studying well.");
            }

            public override void Read()
            {
                Console.WriteLine("BadPupil is not reading well.");
            }

            public override void Write()
            {
                Console.WriteLine("BadPupil is not writing well.");
            }

            public override void Relax()
            {
                Console.WriteLine("BadPupil is not relaxing well.");
            }
        }

        public class ClassRoom
        {
            private Pupil[] pupils;

            public ClassRoom(params Pupil[] pupils)
            {
                if (pupils.Length < 2 || pupils.Length > 4)
                {
                    throw new ArgumentException("The number of pupils must be between 2 and 4.");
                }

                this.pupils = pupils;
            }

            public void ShowPupilsSkills()
            {
                foreach (var pupil in pupils)
                {
                    Console.WriteLine("Pupil:");
                    pupil.Study();
                    pupil.Read();
                    pupil.Write();
                    pupil.Relax();
                    Console.WriteLine();
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //экземпляры учеников
                Pupil pupil1 = new ExcelentPupil();
                Pupil pupil2 = new GoodPupil();
                Pupil pupil3 = new BadPupil();
                Pupil pupil4 = new ExcelentPupil();

                //экземпляр класса ClassRoom
                ClassRoom classRoom = new(pupil1, pupil2, pupil3, pupil4);

                //выводим информацию о навыках учеников
                classRoom.ShowPupilsSkills();
            }
        }
    }


}
