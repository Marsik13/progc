using System;
using System.Collections.Generic;
using Xunit;

namespace Lab2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BookCatalog Catalog = new BookCatalog();//������ ������� �������
            List<FoundBook> FoundBooks = new List<FoundBook>();//�������� �����

            Assert.True(Catalog.AddBook("������ ��������", "������ ���������", "����� � ������������, ��������� � ������� ��������, ���������� ��������� ������� � �������� �� ����������� �������. ������������� ������ �� ���� �������� �����, ���� ���������� �������� � ����� ����� �������.", "978-5-699-12014-7"));
            Assert.True(Catalog.AddBook("����� ������ � ����������� ������", "����� �������","����� �������� ������ �������� �����, ������, ������� �����, ��� �� ��������� � ��� ������������ ���� ��������. �������� � ����� ����������� � ���������� ��������, �� ������� ���� ������� ������, � ������� ������� ������������� ������� ����������� ����� ����������, �������� ��� ���������, ����� ��� ���� ����� ����� �������.", "978-2-621-14033-1"));
            Assert.True(Catalog.AddBook("����� ������ � ������ �������", "����� �������", "����� ������������ � ������ ������� ���� � ����� ����������� � ���������� ��������, �� ������� ����� � ��� ������ � ��� ����� � �������� ��������� � ���������� ������������ ��������� �� �������� �����, ����������� ����� ������������ ���������. ��������� ��������� �������� �������������� �������. ��� ������������ ��������� � ���������� � �� �� ��� �� ���������.", "978-2-621-14033-2"));
            Assert.True(Catalog.AddBook("����� ������ � ����� ��������", "����� �������", "� ������� ����� �����, �������� �� 3-� ����� ����� ����������� � ���������� ��������, ������ �� ������ �������� ������ ������� ������� ����� � ��������� �� ������ ������� ����������, ������� ������������� � ������ �� ����� �����-��-����� � � ��� ���� � ����� �����.", "978-2-621-14033-3"));
            Assert.True(Catalog.AddBook("����� ������ � ����� ����", "����� �������", "�� ������ �������� �����, ����� ������ ����� ���� ����������� � ������� � ������� ��� �����������, � ��� ��������� �� ������ ��������� � ����� �������� �����������, �� � ��������� ������� ����, ��� �� ������ ����� �� ������ ������� ��������. ", "978-2-621-14033-4"));
            Assert.True(Catalog.AddBook("�������� � �������������", "����� �����", "����� �������������� � 1813 ����. ������� ��������, ��� ������� � ������������ ������� �� ����, ��������� ������ ��� ������ �����. ����� � �������� �������� �������� ���������� � ������� ������ �����, �������� ������������������ ��. ������ ������ ������������, ����������, � ����� ����������� �������� � ������������� ���� ���������� ������� ���� �� �������� � ����, ��� ��� ��������, ��������� � ���������� ���� �����, �������� ������� �� �������.", "978-3-961-78353-1"));
            Assert.True(Catalog.AddBook("������� � ����������������", "����� �����", "������� ���� �����: �������������� � ���������� ������ � �����������, ��������� ��������. ����� ������ ����, ������ ������ ������ ����� �����, ��� ���������� � ���������� �� �� ��������.", "978-3-961-78353-2"));
            Assert.True(Catalog.AddBook("����", "����� �����", "����� ������� � �������������� ������ � �������� ������� �������, ������� � ���������� ������� ����� �������� � �������. ���� �������������� �������� � ������� �������������, ���� �������� ������������� ���� �����, ������������� ����� ������ �����. ������ ���������, ��� ��� ������� �� ������ �����, ��� ��������� � ���� ����� ��� ����� ������ � ��������, �� ����� ����������� �� ������� �� ���������.", "978-3-961-78353-3"));

            Assert.True(Catalog.SelectBooksByTitle("�������� � �������������", ref FoundBooks));
            Assert.Single(FoundBooks);
            Assert.Equal("�������� � �������������", FoundBooks[0].Title);

            Assert.True(Catalog.SelectBooksByPartOfTitle("������", ref FoundBooks));
            Assert.Equal(4, FoundBooks.Count);
            Assert.Equal("����� ������ � ����������� ������", FoundBooks[0].Title);
            Assert.Equal("����� ������ � ������ �������", FoundBooks[1].Title);
            Assert.Equal("����� ������ � ����� ��������", FoundBooks[2].Title);
            Assert.Equal("����� ������ � ����� ����", FoundBooks[3].Title);

            Assert.True(Catalog.SelectBooksByAuthor("����� �����", ref FoundBooks));
            Assert.Equal(3, FoundBooks.Count);
            Assert.Equal("�������� � �������������", FoundBooks[0].Title);
            Assert.Equal("������� � ����������������", FoundBooks[1].Title);
            Assert.Equal("����", FoundBooks[2].Title);

            Assert.True(Catalog.SelectBooksByKeyWords("����� ����� �������", ref FoundBooks));
            Assert.Equal(4, FoundBooks.Count);
            Assert.Equal("�������� � �������������", FoundBooks[0].Title);//����� ����� �������
            Assert.Equal("����", FoundBooks[1].Title);//����� �����
            Assert.Equal("������ ��������", FoundBooks[2].Title);//�����
            Assert.Equal("������� � ����������������", FoundBooks[3].Title);//�����

        }
    }
}