import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  url: string = 'https://localhost:7274/api/Authentication/Authorize'
  
  constructor(private http: HttpClient, private jwtHelper: JwtHelperService) { }
  
  Authorize(user: User) {
    return this.http.post(this.url, user);
  }

  SignIn(token: string) {
    localStorage.setItem('token', token);
  }

  IsAuthorized(): boolean {
    const token = localStorage.getItem('token');

    if(token == null){
      return false;
    }

    return !this.jwtHelper.isTokenExpired(token);
  }
}
