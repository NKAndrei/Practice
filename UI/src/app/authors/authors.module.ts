import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorComponent } from './author/author.component';
import { AuthorService } from './services/author.service';



@NgModule({
  declarations: [
    AuthorComponent
  ],
  imports: [
    CommonModule
  ],
  providers: [
    AuthorService
  ]
})
export class AuthorsModule { }
