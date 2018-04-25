using DAL.Models;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dtos
{
    public static class ModelExtensions
    {
        public static CallsEntity ToModel(this CallsDto call)
        {
            return new CallsEntity()
            {
                CallId = call.CallId,
                DestinationNumber = call.DestinationNumber,
                Duration = call.Duration,
                ExternalPrice = call.ExternalPrice,
                LineId = call.LineId,
                //Line = call.Line.ToModel()
            };
        }

        public static CallsDto ToDto(this CallsEntity call)
        {
            return new CallsDto()
            {
                CallId = call.CallId,
                DestinationNumber = call.DestinationNumber,
                Duration = call.Duration,
                ExternalPrice = call.ExternalPrice,
                LineId = call.LineId,
                //Line=call.Line.ToDto()
            };
        }

        public static ClientEntity ToModel(this ClientDto client)
        {
            try
            {
                return new ClientEntity()
                {
                    Address = client.Address,
                    CallsToCenter = client.CallsToCenter,
                    ClientId = client.ClientId,
                    ClientTypeId = client.ClientTypeId,
                    ContactNumber = client.ContactNumber,
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    //ClientType = client.ClientType.ToModel(),
                    //Payments = client.Payments.Select(p => p.ToModel()).ToList(),
                    //Lines = client.Lines.Select(s => s.ToModel()).ToList()
                };
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public static ClientDto ToDto(this ClientEntity client)
        {
            return new ClientDto()
            {
                Address = client.Address,
                CallsToCenter = client.CallsToCenter,
                ClientId = client.ClientId,
                ClientTypeId = client.ClientTypeId,
                ContactNumber = client.ContactNumber,
                FirstName = client.FirstName,
                LastName = client.LastName,
                //ClientType = client.ClientType.ToDto(),
                //Lines=client.Lines.Select(l=>l.ToDto()).ToList(),
                //Payments=client.Payments.Select(p => p.ToDto()).ToList()
            };
        }

        public static ClientTypeEntity ToModel(this ClientTypeDto clientType)
        {
            return new ClientTypeEntity()
            {
                ClientTypeId = clientType.ClientTypeId,
                MinutePrice = clientType.MinutePrice,
                SMSPrice = clientType.SMSPrice,
                TypeName = clientType.TypeName,
                //Clients = clientType.Clients.Select(c => c.ToModel()).ToList()
            };
        }

        public static ClientTypeDto ToDto(this ClientTypeEntity clientType)
        {
            return new ClientTypeDto()
            {
                ClientTypeId=clientType.ClientTypeId,
                MinutePrice=clientType.MinutePrice,
                SMSPrice=clientType.SMSPrice,
                TypeName=clientType.TypeName
                //Clients=clientType.Clients.Select(c=>c.ToDto()).ToList()
            };
        }

        public static LineEntity ToModel(this LineDto line)
        {
            return new LineEntity()
            {
                ClientId = line.ClientId,
                //LineId = line.LineId,
                Number = line.Number,
                PackageId = line.PackageId,
                Status = line.Status,
                //Calls=line.Calls.Select(c=>c.ToModel()).ToList(),
                //Client=line.Client.ToModel(),
                //Package=line.Package.ToModel(),
                //SMS=line.SMS.Select(s=>s.ToModel()).ToList()
            };
        }

        public static LineDto ToDto(this LineEntity line)
        {
            return new LineDto()
            {
                ClientId = line.ClientId,
                LineId = line.LineId,
                Number = line.Number,
                PackageId = line.PackageId,
                Status = line.Status,
                //Calls=line.Calls.Select(c=>c.ToDto()).ToList(),
                //Client=line.Client.ToDto(),
                //Package=line.Package.ToDto(),
                //SMS=line.SMS.Select(s=>s.ToDto()).ToList()
            };
        }

        public static PackageEntity ToModel(this PackageDto package)
        {
            return new PackageEntity()
            {
                PackageId = package.PackageId,
                PackageName = package.PackageName,
                PackageTotalPrice = package.PackageTotalPrice,
                //Lines=package.Lines.Select(l=>l.ToModel()).ToList(),
                //PackageIncludes=package.PackageIncludes.Select(p=>p.ToModel()).ToList()
            };
        }

        public static PackageDto ToDto(this PackageEntity package)
        {
            return new PackageDto()
            {
                PackageId = package.PackageId,
                PackageName = package.PackageName,
                PackageTotalPrice = package.PackageTotalPrice,
                //Lines=package.Lines.Select(p=>p.ToDto()).ToList(),
                //PackageIncludes=package.PackageIncludes.Select(p=>p.ToDto()).ToList()
            };
        }

        public static PackageIncludesEntity ToModel(this PackageIncludesDto package)
        {
            return new PackageIncludesEntity()
            {
                DiscountPrecentage = package.DiscountPrecentage,
                FavoriteNumbersId = package.FavoriteNumbersId,
                FixedPrice = package.FixedPrice,
                Id = package.Id,
                IncludeName = package.IncludeName,
                InsideFamilyCalls = package.InsideFamilyCalls,
                MaxMinute = package.MaxMinute,
                MostCalledNumber = package.MostCalledNumber,
                PackageId = package.PackageId,
                //Package=package.Package.ToModel(),
                //SelectedNumber=package.SelectedNumber.ToModel()
            };
        }

        public static PackageIncludesDto ToDto(this PackageIncludesEntity package)
        {
            return new PackageIncludesDto()
            {
                DiscountPrecentage = package.DiscountPrecentage,
                FavoriteNumbersId = package.FavoriteNumbersId,
                FixedPrice = package.FixedPrice,
                Id = package.Id,
                IncludeName = package.IncludeName,
                InsideFamilyCalls = package.InsideFamilyCalls,
                MaxMinute = package.MaxMinute,
                MostCalledNumber = package.MostCalledNumber,
                PackageId = package.PackageId,
                //Package=package.Package.ToDto(),
                //SelectedNumber=package.SelectedNumber.ToDto()
            };
        }

        public static PaymentEntity ToModel(this PaymentDto payment)
        {
            return new PaymentEntity()
            {
                ClientId = payment.ClientId,
                Date = payment.Date,
                PaymentId = payment.PaymentId,
                TotalPayment = payment.TotalPayment,
                //Client=payment.Client.ToModel()
            };
        }

        public static PaymentDto ToDto(this PaymentEntity payment)
        {
            return new PaymentDto()
            {
                ClientId = payment.ClientId,
                Date = payment.Date,
                PaymentId = payment.PaymentId,
                TotalPayment = payment.TotalPayment,
                //Client=payment.Client.ToDto()
            };
        }

        public static SelectedNumbersEntity ToModel(this SelectedNumbersDto numbers)
        {
            return new SelectedNumbersEntity()
            {
                FirstNumber = numbers.FirstNumber,
                Id = numbers.Id,
                SecondNumber = numbers.SecondNumber,
                ThirdNumber = numbers.ThirdNumber,
                //PackageIncludes=numbers.PackageIncludes.Select(p=>p.ToModel()).ToList()
            };
        }

        public static SelectedNumbersDto ToDto(this SelectedNumbersEntity numbers)
        {
            return new SelectedNumbersDto()
            {
                FirstNumber = numbers.FirstNumber,
                Id = numbers.Id,
                SecondNumber = numbers.SecondNumber,
                ThirdNumber = numbers.ThirdNumber,
                //PackageIncludes=numbers.PackageIncludes.Select(p=>p.ToDto()).ToList()
            };
        }

        public static SMSEntity ToModel(this SMSDto sms)
        {
            return new SMSEntity()
            {
                DestinationNumber = sms.DestinationNumber,
                ExternalPrice = sms.ExternalPrice,
                LineId = sms.LineId,
                SMSId = sms.SMSId,
                //Line=sms.Line.ToModel()
            };
        }

        public static SMSDto ToDto(this SMSEntity sms)
        {
            return new SMSDto()
            {
                DestinationNumber = sms.DestinationNumber,
                ExternalPrice = sms.ExternalPrice,
                LineId = sms.LineId,
                SMSId = sms.SMSId,
                //Line=sms.Line.ToDto()
            };
        }
    }
}