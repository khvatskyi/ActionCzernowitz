import { Component, Input, OnInit } from '@angular/core';
import { NewsService } from 'src/app/services/news.service';

@Component({
  selector: 'app-last-news',
  templateUrl: './last-news.component.html',
  styleUrls: ['./last-news.component.scss']
})
export class LastNewsComponent implements OnInit {

  news: any;

  @Input() isAuthorized: boolean = false;

  constructor(private newsService: NewsService) {
    this.newsService.GetLastNews()
      .subscribe((data: any) => {
        console.log(data);
        this.news = data;
      });
   }

  ngOnInit(): void {
  }

}
