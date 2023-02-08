import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookComponent } from './book/book.component';
import { BookService } from './services/book.service';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    BookComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  providers: [
    BookService
  ]
})
export class BooksModule { }
