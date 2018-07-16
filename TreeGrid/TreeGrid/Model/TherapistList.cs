using System.Collections.Generic;

namespace TreeGrid.Model
{
    public class TherapistList : List<Therapist>
    {
        private static TherapistList _therapistList;

        private TherapistList()
        {
        }

        public static TherapistList Instance()
        {
            if (_therapistList == null)
                CreateAndPopulate();

            return _therapistList;
        }

        private static void CreateAndPopulate()
        {
            _therapistList = new TherapistList
            {
                new Therapist
                {
                    TherapistName = "Dr. Lucius Livius Andronicus",
                    TherapyId = 1
                },
                new Therapist
                {
                    TherapistName = "Dr. Gnaeus Naevius",
                    TherapyId = 1
                },
                new Therapist
                {
                    TherapistName = "Dr. Quintus Ennius",
                    TherapyId = 1
                },
                new Therapist
                {
                    TherapistName = "Dr. Marcus Pacuvius",
                    TherapyId = 2
                },
                new Therapist
                {
                    TherapistName = "Dr. Lucius Accius",
                    TherapyId = 3
                },
                new Therapist
                {
                    TherapistName = "Dr. Titus Maccius Plautus",
                    TherapyId = 3
                },
                new Therapist
                {
                    TherapistName = "Dr. Publius Terentius Afer (Dr. Terence)",
                    TherapyId = 4
                },
                new Therapist
                {
                    TherapistName = "Dr. Marcus Porcius Cato (Dr. Cato the Elder)",
                    TherapyId = 5
                },
                new Therapist
                {
                    TherapistName = "Dr. Gaius Lucilius",
                    TherapyId = 5
                },
                new Therapist
                {
                    TherapistName = "Dr. Marcus Tullius Cicero",
                    TherapyId = 5
                },
                new Therapist
                {
                    TherapistName = "Dr. Publius Ovidius Naso (Dr. Ovid)",
                    TherapyId = 5
                },
                new Therapist
                {
                    TherapistName = "Dr. Gaius Valerius Catullus",
                    TherapyId = 5
                }
            };
        }
    }
}