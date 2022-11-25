using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModels
{
    /*CREATE TABLE `Ip` (
    `value` VARCHAR(191) NOT NULL,
    `country` VARCHAR(191) NOT NULL,
    `city` VARCHAR(191) NOT NULL,
    `longitude` DOUBLE NOT NULL DEFAULT 0.0,
    `latitude` DOUBLE NOT NULL DEFAULT 0.0,

    PRIMARY KEY (`value`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;*/
    public class Ip
    {
        [Key]
        public string Value { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }
    }
}
