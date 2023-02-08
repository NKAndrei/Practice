import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorComponent } from './authors/author/author.component';
import { BookComponent } from './books/book/book.component';

const routes: Routes = [
  { path: 'authors', component: AuthorComponent},
  { path: 'books', component: BookComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
