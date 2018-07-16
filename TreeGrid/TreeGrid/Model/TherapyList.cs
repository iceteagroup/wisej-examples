using System.Collections.Generic;

namespace TreeGrid.Model
{
    public class TherapyList : List<Therapy>
    {
        private static TherapyList _therapyList;

        private TherapyList()
        {
        }

        public static TherapyList Instance()
        {
            if (_therapyList == null)
                CreateAndPopulate();

            return _therapyList;
        }

        private static void CreateAndPopulate()
        {
            _therapyList = new TherapyList
            {
                new Therapy
                {
                    TherapyId = 1,
                    TherapyName = "Acupuncture"
                },
                new Therapy
                {
                    TherapyId = 2,
                    TherapyName = "Osmotherapy"
                },
                new Therapy
                {
                    TherapyId = 3,
                    TherapyName = "Prolotherapy"
                },
                new Therapy
                {
                    TherapyId = 4,
                    TherapyName = "Helminthic Therapy"
                },
                new Therapy
                {
                    TherapyId = 5,
                    TherapyName = "Physiotherapy"
                }
            };
        }
    }
}