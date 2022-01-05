import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-magazines-content',
  templateUrl: './magazines-content.component.html',
  styleUrls: ['./magazines-content.component.scss']
})
export class MagazinesContentComponent implements OnInit {

  src = '../../../assets/pdfs/1.pdf';

  constructor() { }

  ngOnInit(): void {
  }

}
