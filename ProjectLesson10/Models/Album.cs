namespace ProjectLesson10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        /// <summary>
        /// This constructor takes one argument title which sets the Title property to its value
        /// </summary>
        /// <param name="title"></param>
        public Album(string title)
        {
            this.Title = title;
        }
        /// <summary>
        /// This is an empty Album constructor
        /// </summary>
        public Album()
        {

        }

        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        [Display(Name = "Album Title")]
        [Required]
        [StringLength(160)]
        public string Title { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
