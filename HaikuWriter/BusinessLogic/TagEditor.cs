using System;

namespace BusinessLogic
{
    public class TagEditor
    {
        public string TagLine { get; set; }
        public Haiku HaikuHolder { get; set; }
        public HaikuLine HaikuLineHolder { get; set; }
        public TagEditor(Haiku haiku, string newTag)
        {
            HaikuHolder = haiku;
            TagLine = AddTag(RetrieveTag(HaikuHolder), newTag);
        }
        public TagEditor(HaikuLine haikuline, string newTag)
        {
            HaikuLineHolder = haikuline;
            TagLine = AddTag(RetrieveTag(HaikuLineHolder), newTag);
        }
        public string RetrieveTag<T>(T taggy)
        {
            
            string oldTags = taggy.Tags;
            return oldTags;
        }

        public string AddTag(string oldTag, string newTag)
        {
            string addedTag = oldTag + ", " + newTag;
            return addedTag;
        }

    }   
}
