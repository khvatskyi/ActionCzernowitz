import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { JwtHelperService } from '@auth0/angular-jwt';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  constructor(private http: HttpClient, private jwtHelper: JwtHelperService) { }

  Authorize(user: User) {
    const path = 'Authentication/Authorize';

    return this.http.post(environment.apiBaseUrl + path, user);
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
