using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModels
{
    /*CREATE TABLE `Receiver` (
    `id` INTEGER NOT NULL AUTO_INCREMENT,
    `token` VARCHAR(191) NOT NULL,
    `paymentSystem` ENUM('QiwiP2P', 'QiwiDirect', 'QiwiCard', 'YooMoney', 'Card') NOT NULL,
    `bin` VARCHAR(6) NULL,
    `txnMin` INTEGER NOT NULL,
    `txnMax` INTEGER NOT NULL,
    `supportId` INTEGER NULL,
    `received` DECIMAL(65, 30) NOT NULL DEFAULT 0,
    `enabled` BOOLEAN NOT NULL DEFAULT true,
    `meta` JSON NOT NULL,

    UNIQUE INDEX `ps_token`(`paymentSystem`, `token`),
    PRIMARY KEY (`id`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;*/
    public class Receiver
    {
        public Guid Id { get; set; }

        public string Token { get; set; }

        public PaymentSystemEnum PaymentSystem { get; set; }

        //FK
        public string BinValue { get; set; }
        public Bin Bin { get; set; }

        public int TxnMin { get; set; }

        public int TxnMax { get; set; }

        public int SupportId { get; set; }

        public double Received { get; set; }

        public bool Enabled { get; set; }

        public string Meta { get; set; }
    }

    public enum PaymentSystemEnum
    {
        Qiwi,
        YooMoney
    }
}
