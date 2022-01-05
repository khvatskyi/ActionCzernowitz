import { Component, OnInit } from '@angular/core';
import { AuthorizationService } from 'src/app/services/authorization.service';

@Component({
  selector: 'app-home-content',
  templateUrl: './home-content.component.html',
  styleUrls: ['./home-content.component.scss']
})
export class HomeContentComponent implements OnInit {

  isAuthorized: boolean = false;

  constructor(private authService: AuthorizationService) {
    this.isAuthorized = authService.IsAuthorized();
   }

  ngOnInit(): void {
  }
}
