namespace Models.Models.utilities
{

    public class DistanceResponse
    {
        public string[] destination_addresses { get; set; }
        public string[] origin_addresses { get; set; }
        public row[] rows { get; set; }
        public string status { get; set; }

        public class distance
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class duration
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class element
        {
            public distance distance { get; set; }
            public duration duration { get; set; }
            public string status { get; set; }
        }

        public class row
        {
            public element[] elements { get; set; }
        }
    }
}
