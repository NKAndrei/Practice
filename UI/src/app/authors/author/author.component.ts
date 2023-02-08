import { Component, OnInit } from '@angular/core';
import { AuthorModel } from '../models/author-model';
import { AuthorService } from '../services/author.service';

@Component({
  selector: 'app-author',
  templateUrl: './author.component.html',
  styleUrls: ['./author.component.css']
})
export class AuthorComponent implements OnInit {
  service : AuthorService;
  author : AuthorModel;
  authors : AuthorModel[];
  constructor(authorService : AuthorService) {
    this.service = authorService;
   }

  ngOnInit(): void {
    this.service.getAuthor(1).subscribe(author => this.author = author);
    this.service.getAllAuthors().subscribe(authors => this.authors = authors);
  }

}
