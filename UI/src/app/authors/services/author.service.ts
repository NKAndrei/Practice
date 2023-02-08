import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AuthorModel } from '../models/author-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {
  http : HttpClient;
  constructor(httpClient : HttpClient) {
    this.http = httpClient;
  }

  getAuthor(authorId : number) : Observable<AuthorModel>{
    return this.http.get<AuthorModel>(`https://localhost:44328/Author/${authorId}`);
  }
  addAuthor(author : AuthorModel) : Observable<AuthorModel>{
    return this.http.post<AuthorModel>("https://localhost:44328/Author/add", author);
  }
  getAllAuthors() : Observable<AuthorModel[]>{
    return this.http.get<AuthorModel[]>("https://localhost:44328/Author/all");
  }
}
