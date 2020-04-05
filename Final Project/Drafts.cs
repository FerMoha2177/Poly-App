using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    //[Serializable]    //FIXME: this is only if this class is going to be serialized
    public class Drafts : IEnumerable<Email>
    {
        List<Email> EmailDrafts;
        public IEnumerator<Email> GetEnumerator()
        {
            return EmailDrafts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Drafts()
        {
            EmailDrafts = new List <Email> ();
        }
        public Email this[int i]
        {
            get { return EmailDrafts[i]; }
            set { EmailDrafts[i] = value; }

        }

        /// <summary>
        /// adds a new email to the list
        /// </summary>
        /// <param name="e"></param>
        public void Add(Email e)
        {
            EmailDrafts.Add(e);
        }

        /// <summary>
        /// removes given item from the list
        /// </summary>
        /// <param name="e"></param>
        public void Remove(Email e)
        {
            EmailDrafts.Remove(e);
        }

        /// <summary>
        /// removes item at given index from the list
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            int count = 0;
            foreach (Email item in EmailDrafts)
            {
                if (count++ == index)
                {
                    EmailDrafts.Remove(item);
                }
            }
        }

        /// <summary>
        /// returns the number of items on the list
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return EmailDrafts.Count();
        }


    }
}
