import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  url: string = 'https://localhost:7274/api/Authentication/Authorize'

  constructor(private http: HttpClient) { }

  Authorize(user: User) {
    return this.http.post(this.url, user);
  }
}
