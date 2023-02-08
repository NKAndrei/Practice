import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BookModel } from '../models/book-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookService {
  http : HttpClient
  constructor(httpClient : HttpClient) {
    this.http = httpClient;
  }

  getBook(bookId : number) : Observable<BookModel>{
    return this.http.get<BookModel>(`https://localhost:44328/Book/${bookId}`);
  }
  addBook(book : BookModel) : Observable<BookModel>{
    return this.http.post<any>("https://localhost:44328/Book/add", book);
  }
  getAllBooks() : Observable<BookModel[]>{
    return this.http.get<BookModel[]>("https://localhost:44328/Book/all");
  }
}
