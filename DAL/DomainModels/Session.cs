using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* CreateTable
CREATE TABLE `Session` (
    `id` INTEGER NOT NULL AUTO_INCREMENT,
    `displayName` VARCHAR(191) NULL,
    `token` VARCHAR(1024) NOT NULL,
    `loggedInAt` DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    `lastActiveAt` DATETIME(3) NOT NULL,
    `ip` VARCHAR(191) NOT NULL,
    `userAgent` VARCHAR(191) NOT NULL,

    PRIMARY KEY (`id`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;*/

namespace DAL.DomainModels
{
    public class Session
    {
        public Guid Id { get; set; }

        public string DisplayName { get; set; }

        public string Token { get; set; }

        public DateTime LoggedInAt { get; set; }

        public DateTime LastActiveAt { get; set; }
        
        //FK
        public string IpValue { get; set; }
        
        public Ip Ip { get; set; }

        public string UserAgent { get; set; }


    }
}
