import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { catchError, throwError } from 'rxjs';
import { User } from 'src/app/models/user';
import { AuthorizationService } from 'src/app/services/authorization.service';

@Component({
  selector: 'app-admin-authorization-content',
  templateUrl: './admin-authorization-content.component.html',
  styleUrls: ['./admin-authorization-content.component.scss']
})
export class AdminAuthorizationContentComponent implements OnInit {

  username: String = "";
  password: String = "";
  validationError: String = "";

  constructor(private authorizationService: AuthorizationService) { }

  ngOnInit(): void {
  }

  onAuthorize() {
    this.authorizationService.Authorize(new User(this.username,this.password))
      .subscribe((data: any) => {
        this.validate(data);
      });
  }

  validate(data: any) {
    if(data?.successful) {
      this.validationError = "Правильний логін та пароль";
    } else {
      this.validationError = "Неправильний логін чи пароль";
    }
  }
}
