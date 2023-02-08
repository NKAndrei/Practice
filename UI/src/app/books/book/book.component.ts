import { Component, OnInit } from '@angular/core';
import { BookModel } from '../models/book-model';
import { BookService } from '../services/book.service';


@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  service : BookService;
  book : BookModel;
  modifiedBook : BookModel;
  books : BookModel[];
  message : String;
  newBook : BookModel = new BookModel;
  constructor(bookService : BookService) {
    this.service = bookService;
  }

  ngOnInit(): void {
    //this.service.getBook(1).subscribe(book => this.book = book);
    this.service.getAllBooks().subscribe(books => this.books = books);
  }
  addBook() : void {
    alert("adding a book");
    this.service.addBook(this.newBook).subscribe(returnMessage => this.message = returnMessage.Title);
    alert(this.message);
  }
  getBookById(bookId : string) : void{
    this.service.getBook(parseInt(bookId)).subscribe(returnedBook => this.book = returnedBook);
  }
  modifyBook() : void{
    this.modifiedBook = this.book;
  }
}
