import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-action-abbreviation',
  templateUrl: './action-abbreviation.component.html',
  styleUrls: ['./action-abbreviation.component.scss']
})
export class ActionAbbreviationComponent implements OnInit {

  letters: any = [{
    letter: "A",
    description: "аналіз"
  },{
    letter: "С",
    description: "колектив"
  },{
    letter: "T",
    description: "текст"
  },{
    letter: "I",
    description: "ідейність"
  },{
    letter: "O",
    description: "об'єктивність"
  },{
    letter: "N",
    description: "напрям думок"
  },]

  constructor() { }

  ngOnInit(): void {
  }

}
