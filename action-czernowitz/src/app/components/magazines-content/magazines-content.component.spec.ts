import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MagazinesContentComponent } from './magazines-content.component';

describe('MagazinesContentComponent', () => {
  let component: MagazinesContentComponent;
  let fixture: ComponentFixture<MagazinesContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MagazinesContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MagazinesContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
