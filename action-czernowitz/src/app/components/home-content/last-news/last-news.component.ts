import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-last-news',
  templateUrl: './last-news.component.html',
  styleUrls: ['./last-news.component.scss']
})
export class LastNewsComponent implements OnInit {

  news: any = [{
    image: "../../../../assets/images/news1.png",
    date: "04.12.2021",
    title: "Прем‘єра фільму «Хто ми? Психоаналіз українців»",
    description: "10 грудня о 19:00 у культурно-мистецькому центрі імені Івана Миколайчука відбудеться прем‘єра фільму «Хто ми? Психоаналіз українців»..."
  },{
    image: "../../../../assets/images/news2.png",
    date: "04.12.2021",
    title: "Прем‘єра фільму «Хто ми? Психоаналіз українців»",
    description: "10 грудня о 19:00 у культурно-мистецькому центрі імені Івана Миколайчука відбудеться прем‘єра фільму «Хто ми? Психоаналіз українців»..."
  },{
    image: "../../../../assets/images/news3.png",
    date: "04.12.2021",
    title: "Прем‘єра фільму «Хто ми? Психоаналіз українців»",
    description: "10 грудня о 19:00 у культурно-мистецькому центрі імені Івана Миколайчука відбудеться прем‘єра фільму «Хто ми? Психоаналіз українців»..."
  }
] 
  
  constructor() { }

  ngOnInit(): void {
  }

}
