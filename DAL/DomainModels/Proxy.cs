using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModels
{
    /*CREATE TABLE `Proxy` (
    `url` VARCHAR(191) NOT NULL,
    `ip` VARCHAR(191) NOT NULL,
    `addedAt` DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    `checkedAt` DATETIME(3) NOT NULL,
    `valid` BOOLEAN NOT NULL,

    UNIQUE INDEX `Proxy_ip_key`(`ip`),
    PRIMARY KEY (`url`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
*/
    public class Proxy
    {
        public string Url { get; set; }

        //FK
        public string IpValue { get; set; }
        public Ip Ip { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AddedAt { get; set; }

        public DateTime CheckedAt { get; set; }

        public bool Valid { get; set; }
    }
}
