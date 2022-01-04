import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActionAbbreviationComponent } from './action-abbreviation.component';

describe('ActionAbbreviationComponent', () => {
  let component: ActionAbbreviationComponent;
  let fixture: ComponentFixture<ActionAbbreviationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ActionAbbreviationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ActionAbbreviationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
