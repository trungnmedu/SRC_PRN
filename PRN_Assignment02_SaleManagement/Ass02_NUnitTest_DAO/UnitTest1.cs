using DataAccess.Repository.MemberRepo;
using NUnit.Framework;
using System;
using System.Linq;

namespace Ass02_NUnitTest_DAO
{
    public class Tests
    {
        private IMemberRepository memberRepository;
        [SetUp]
        public void Setup()
        {
            memberRepository = new MemberRepository();
        }

        [Test]
        public void LoginSuccess()
        {
            Assert.IsNotNull(memberRepository.Login("phong@gmail.com", "123456"));
        }

        [Test]
        public void LoginFail()
        {
            Assert.IsNull(memberRepository.Login("adc@yahoo.com.vn", "1133"));
        }

        [Test]
        public void GetMemberSuccess_MemberID()
        {
            Assert.IsNotNull(memberRepository.GetMember(2));
        }

        [Test]
        public void GetMemberSuccess_Email()
        {
            Assert.IsNotNull(memberRepository.GetMember("phong@gmail.com"));
        }

        [Test]
        public void GetMemberFail_Email()
        {
            Assert.IsNull(memberRepository.GetMember("abcas@gmail.com"));
        }

        [Test]
        public void AddMember()
        {
            memberRepository.AddMember(new BusinessObject.Member
            {
                Email = "ntranphongse@gmail.com",
                Fullname = "PhongNT FPTU",
                Password = "123456",
                City = "Vung Tau",
                Country = "Vietnam"
            });
            Assert.IsNotNull(memberRepository.GetMember("ntranphongse@gmail.com"));
            Assert.AreEqual(memberRepository.GetMember("ntranphongse@gmail.com").Fullname, "PhongNT FPTU");
        }

        [Test]
        public void AddMemberFail()
        {
            Assert.Throws<Exception>(
                () =>
                {
                    memberRepository.AddMember(new BusinessObject.Member
                    {
                        Email = "ntranphongse@gmail.com",
                        Fullname = "PhongNT FPTU",
                        Password = "123456",
                        City = "Vung Tau",
                        Country = "Vietnam"
                    });
                });
        }

        [Test]
        public void Update()
        {

            memberRepository.UpdateMember(new BusinessObject.Member
            {
                MemberId = 2,
                Email = "phongntse150974@fpt.edu.vn",
                Fullname = "Nguyen Tran Phong FPTU",
                City = "Ho Chi Minh",
                Country = "Vietnam",
                Password = "123456"
            });
            Assert.IsNotNull(memberRepository.GetMember(2));
            Assert.AreEqual(memberRepository.GetMember(2).Fullname, "Nguyen Tran Phong FPTU");
        }

        [Test]
        public void UpdateFail()
        {
            Assert.Throws<Exception>(
                () =>
                {
                    memberRepository.UpdateMember(new BusinessObject.Member
                    {
                        MemberId = 250,
                        Fullname = "Phong Phong"
                    });
                });
        }

        [Test]
        public void SearchMember()
        {
            var members = memberRepository.SearchMember("a");
            Assert.NotNull(members);
            //Assert.AreEqual(members.Count(), 8);
        }

        [Test]
        public void DeleteMember()
        {
            var memberId = memberRepository.GetMember("ntranphongse@gmail.com").MemberId;
            memberRepository.DeleteMember(memberId);
            Assert.IsNull(memberRepository.GetMember("ntranphongse@gmail.com"));
        }
    }
}
