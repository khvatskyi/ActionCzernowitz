import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class NewsService {

  constructor(private http: HttpClient) { }

  GetLastNews() {
    const path = "News/GetAll";

    return this.http.get(environment.apiBaseUrl + path);
  }
}
