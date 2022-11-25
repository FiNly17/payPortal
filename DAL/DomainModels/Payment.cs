using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModels
{
    /*`id` VARCHAR(191) NOT NULL,
    `createdAt` DATETIME(3) NOT NULL DEFAULT CURRENT_TIMESTAMP(3),
    `settledAt` DATETIME(3) NULL,
    `status` ENUM('CREATED', 'PAID', 'CANCELLED', 'EXPIRED') NOT NULL DEFAULT 'CREATED',
    `amount` DECIMAL(65, 30) NOT NULL,
    `dismissed` BOOLEAN NOT NULL DEFAULT false,
    `receiverId` INTEGER NOT NULL,
    `billId` VARCHAR(191) NOT NULL,
    `errorType` ENUM('NOT_ENOUGH_MONEY', 'CARD_INVALID', 'TDS_DECLINED', 'BANK_DECLINED', 'PROCESSING_ERROR', 'CANCELLED') NULL,
    `errorMessage` VARCHAR(191) NULL,
    `meta` JSON NOT NULL,

    PRIMARY KEY (`id`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;*/
    public class Payment
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime SettledAt { get; set; }

        public StatusEnum Status { get; set; }

        public Guid BillId { get; set; }
        public Bill Bill { get; set; }

        public double Amount { get; set; }

        public bool Dismissed { get; set; }

        public int ReceivedId { get; set; }

        public ErrorTypeEnum ErrorType { get; set; }

        public string ErrorMessage { get; set; }

        public string Meta { get; set; }
    }

    public enum ErrorTypeEnum
    {
        NOT_ENOUGH_MONEY,
        CARD_INVALID,
        TDS_DECLINED,
        BANK_DECLINED,
        PROCESSING_ERROR
    }
}
