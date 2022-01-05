import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directions',
  templateUrl: './directions.component.html',
  styleUrls: ['./directions.component.scss']
})
export class DirectionsComponent implements OnInit {

  directions : any = [{
    number: '01',
    title: 'Організація івентів'
  },
  {
    number: '02',
    title: 'Просвітницька діяльність'
  },
  {
    number: '03',
    title: 'Популяризація української літератури'
  },
  {
    number: '04',
    title: 'Популяризація культури'
  },
  {
    number: '05',
    title: 'Підтримка митців та мисткинь'
  },
  {
    number: '06',
    title: 'Видання щомісячника'
  },
]
  
  constructor() { }

  ngOnInit(): void {
  }

}
