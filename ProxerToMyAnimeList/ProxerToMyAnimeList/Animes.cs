﻿namespace ProxerToMyAnimeList
{
    public class Animes
    {
        private string myProxID;
        private string myAnimeListID;
        private string myName;
        private enum myStatus
        {
            watched, watching, willbewatched, aborted
        }
        public Animes(string ProxID, string Name)
        {
            this.myProxID = ProxID;
            this.myName = Name;
        }

        public void getMyAnimeListID()
        {
            //todo perform search on my anime list with name, save id in class 
        }
        public void AddtoMyAnimeList()
        {

        }
        public void generateMyAnimeListXML()
        {
            //maybe easier then implementing with the add function (and we wouldnt brutforce their server so hard)
        }
    }
}