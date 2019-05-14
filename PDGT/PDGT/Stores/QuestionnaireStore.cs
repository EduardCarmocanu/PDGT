using Akavache;
using PDGT.Models;
using System;
using System.Reactive.Linq;
using System.Collections.Generic;
using System.Text;

namespace PDGT.Stores
{
    class QuestionnaireStore
    {
        public static void SetPreQuestionnaire(PreQuestionnaire p)
        {
            PreQuestionnaire CurrentPreQuestionnaire = p;
            BlobCache.LocalMachine.InsertObject<PreQuestionnaire>("PreQuestionnaire", CurrentPreQuestionnaire).Wait();
        }

        public static PreQuestionnaire GetPreQuestionnaire()
        {
            PreQuestionnaire p = new PreQuestionnaire();

            try
            {
                p = BlobCache.LocalMachine.GetObject<PreQuestionnaire>("PreQuestionnaire").Wait();
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Nothing to get.");
            }
            return p;
        }
    }
}
