import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NewsService {

  url: string = 'https://localhost:7274/api/News/GetAll'

  constructor(private http: HttpClient) { }

  GetLastNews() {
    return this.http.get(this.url);
  }
}
