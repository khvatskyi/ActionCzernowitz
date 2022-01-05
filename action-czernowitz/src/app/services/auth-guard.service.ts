import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthorizationService } from './authorization.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService implements CanActivate {

  constructor(private authorizationService: AuthorizationService, private router: Router) { }

  canActivate(): boolean {
    if (!this.authorizationService.IsAuthorized()) {
      this.router.navigate(['admin']);
      return false;
    }
    return true;
  }
}
